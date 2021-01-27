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
        string RedirectURL;
        protected void Page_Load(object sender, EventArgs e)
        {
            RoomID = Convert.ToInt32(Session["RoomID"]);
            RedirectURL = Convert.ToString(Session["Mode"]);
            if (Session["RoomID"] == null) { Response.Redirect("Default.aspx"); }
            clsRoomCollection Rooms = new clsRoomCollection();
            Rooms.Find(RoomID);
            lblDelete.Text = $"Are you sure you want to delete room {Rooms.ThisRoom.RoomName}";
            if (Convert.ToString(Session["Mode"]) == "Admin") { RedirectURL = "ManageRooms.aspx"; }
            else { RedirectURL = "Default.aspx"; }
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRooms.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            clsRoomCollection RoomList = new clsRoomCollection();
            if (Convert.ToString(Session["Mode"]) == "Admin") 
            { 
                RoomList.Delete(RoomID);
                Response.Redirect("ManageRooms.aspx");
            }
            else
            {
                RedirectURL = "Default.aspx";
            }
        }
    }
}