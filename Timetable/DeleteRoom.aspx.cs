using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class DeleteRoom : System.Web.UI.Page
    {
        Int32 RoomID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Sets RoomID variable, if blank then redirects to login since it should not be blank
            RoomID = Convert.ToInt32(Session["RoomID"]);
            if (Session["RoomID"] == null) { Response.Redirect("TeacherLogin.aspx"); }

            //Finds RoomID, changes page text depending on the room name for that Room ID
            clsRoomCollection Rooms = new clsRoomCollection();
            Rooms.Find(RoomID);
            lblDelete.Text = $"Are you sure you want to delete room {Rooms.ThisRoom.RoomName}";
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //Redirects back to room management page
            Response.Redirect("ManageRooms.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //Run when btnYes is clicked, deletes room if Mode is admin
            clsRoomCollection RoomList = new clsRoomCollection();
            if (Convert.ToString(Session["Mode"]) == "Admin") 
            { 
                RoomList.Delete(RoomID);
                Response.Redirect("ManageRooms.aspx");
            }
            else { Response.Redirect("Default.aspx"); }
        }
    }
}