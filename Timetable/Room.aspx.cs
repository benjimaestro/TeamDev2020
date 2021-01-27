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
            clsRoomCollection Rooms = new clsRoomCollection();

            foreach (string block in Rooms.AvailableBlocks)
            {
                ddlBlock.Items.Add(block);
            }

            foreach (string subject in Rooms.AvailableSubjects)
            {
                ddlSubject.Items.Add(subject);
            }

            RoomID = Convert.ToInt32(Session["RoomID"]);
            Mode = Convert.ToString(Session["Mode"]);
            if (RoomID != -1)
            {
                if (IsPostBack == false)
                {
                    lblTitle.Text = "Change account details";
                    Rooms.Find(RoomID);
                    txtRoomNo.Text = Convert.ToString(Rooms.ThisRoom.Number);
                }
            }
            else { lblTitle.Text = "New Room"; }
        }

        string add()
        {
            String Error = "";
            clsRoomCollection PreRooms = new clsRoomCollection();
            PreRooms.FindExistingRoom(ddlBlock.Text, Convert.ToInt32(txtRoomNo.Text));
            if (PreRooms.ThisRoom.Block != null)
            {
                Error = Error + "Room number already exists in that block!</br>";
            }
            clsRoomCollection Rooms = new clsRoomCollection();

            //Error = Error + Rooms.ThisRoom.Valid();
            if (Error == "")
            {
                Rooms.ThisRoom.Block = Convert.ToString(ddlBlock.SelectedValue);
                Rooms.ThisRoom.Number = Convert.ToInt32(txtRoomNo.Text);
                if (ddlSubject.SelectedValue != "Any")
                {
                    Rooms.ThisRoom.Subject = Convert.ToString(ddlSubject.SelectedValue);
                }
                else { Rooms.ThisRoom.Subject = null; }
                Rooms.Add();
                return Error;
            }
            else
            {
                lblError.Text = Error;
                return Error;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (RoomID == -1)
            {
                string Error = add();
                if (Error == "")
                {
                    if (Mode != "Admin") { Response.Redirect("Default"); }
                    else { Response.Redirect("ManageRooms.aspx"); }
                }
            }
            else
            {
                //string Error = update();
                //if (Error == "")
                //{
                //    if (Mode != "Admin")
                //    {
                //        Response.Redirect("Default.aspx");
                //    }
                //}
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRooms.aspx");
        }
    }
}