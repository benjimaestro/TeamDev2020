using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class Room : System.Web.UI.Page
    {
        Int32 RoomID;
        string Mode;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get list of valid blocks and subjects to add to ddlBlock and ddlSubject
            clsRoomCollection Rooms = new clsRoomCollection();
            foreach (string block in Rooms.AvailableBlocks)
            {
                ddlBlock.Items.Add(block);
            }
            foreach (string subject in Rooms.AvailableSubjects)
            {
                ddlSubject.Items.Add(subject);
            }

            //Get RoomID and Mode session objects, if RoomID is -1,
            //then a new room is being added, otherwise edit room of the provided ID.
            RoomID = Convert.ToInt32(Session["RoomID"]);
            Mode = Convert.ToString(Session["Mode"]);
            if (RoomID != -1)
            {
                if (IsPostBack == false)
                {
                    lblTitle.Text = "Change room details";
                    Rooms.Find(RoomID);
                    txtRoomNo.Text = Convert.ToString(Rooms.ThisRoom.Number);
                    ddlBlock.SelectedValue = Rooms.ThisRoom.Block;
                    ddlSubject.SelectedValue = Rooms.ThisRoom.Subject;
                }
            }
            else { lblTitle.Text = "New Room"; }
        }

        string add()
        {
            //Function to validate a room's info, and if it is valid then add it to DB
            //Room is checked so see if a number already exists in a block
            String Error = "";
            clsRoomCollection PreRooms = new clsRoomCollection();
            PreRooms.FindExistingRoom(ddlBlock.Text, Convert.ToInt32(txtRoomNo.Text));
            if (PreRooms.ThisRoom.Block != null)
            {
                Error = Error + "Room number already exists in that block!</br>";
            }

            //Room is also checked to make sure other details are valid
            clsRoomCollection Rooms = new clsRoomCollection();
            Error = Error + Rooms.ThisRoom.Validate(ddlBlock.SelectedValue, txtRoomNo.Text, ddlSubject.SelectedValue);
            if (Error == "")
            {
                Rooms.ThisRoom.Block = Convert.ToString(ddlBlock.SelectedValue);
                Rooms.ThisRoom.Number = Convert.ToInt32(txtRoomNo.Text);
                Rooms.ThisRoom.Subject = Convert.ToString(ddlSubject.SelectedValue);
                Rooms.Add();
                return Error;
            }
            else
            {
                lblError.Text = Error;
                return Error;
            }
        }

        string edit()
        {
            //Function to validate a room's info, and if it is valid then edit its existing records with new info
            String Error = "";
            clsRoomCollection PreRooms = new clsRoomCollection();
            clsRoomCollection Rooms = new clsRoomCollection();
            PreRooms.FindExistingRoom(ddlBlock.Text, Convert.ToInt32(txtRoomNo.Text));
            Rooms.FindExistingRoom(ddlBlock.Text, Convert.ToInt32(txtRoomNo.Text));

            //Room is checked so see if a number already exists in a block and is not the room being edited
            if (PreRooms.ThisRoom.Number.ToString() != null)
            {
                if (PreRooms.ThisRoom.Number != Convert.ToInt32(txtRoomNo.Text) && PreRooms.ThisRoom.Block != ddlBlock.SelectedValue && PreRooms.ThisRoom.ID != RoomID)
                { Error = Error + "Room number already exists in block </br>"; }
            }

            //Room is also checked to make sure other details are valid
            Error = Error + Rooms.ThisRoom.Validate(ddlBlock.SelectedValue,txtRoomNo.Text, ddlSubject.SelectedValue);
            if (Error == "")
            {
                Rooms.Find(RoomID);
                Rooms.ThisRoom.Number = Convert.ToInt32(txtRoomNo.Text);
                Rooms.ThisRoom.Block = ddlBlock.SelectedValue;
                Rooms.ThisRoom.Subject = ddlSubject.SelectedValue;
                Rooms.Edit();
                Session["RoomID"] = Rooms.ThisRoom.ID;
                return Error;
            }
            else
            {
                lblError.Text = Error;//Display errors
                return Error;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //Run when btnRegister is clicked
            //If RoomID is -1, run for new room being added
            //Otherwise, edit room of provided ID
            if (RoomID == -1)
            {
                string Error = add();
                if (Error == "")
                {
                    if (Mode != "Admin") { Response.Redirect("Default"); }
                    else { Response.Redirect("ManageRooms.aspx"); }
                }
                else { lblError.Text = Error; }
            }
            else
            {
                string Error = edit();
                if (Error == "")
                {
                    if (Mode != "Admin") { Response.Redirect("Default"); }
                    else { Response.Redirect("ManageRooms.aspx"); }
                }
                else { lblError.Text = Error; }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //Returns user back to ManageRooms
            Response.Redirect("ManageRooms.aspx");
        }
    }
}