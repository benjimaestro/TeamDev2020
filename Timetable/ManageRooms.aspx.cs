using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace Timetable
{
    public partial class ManageRooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DisplayRooms();
            }
        }

        void DisplayRooms()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            lstRooms.Items.Clear();
            lstRooms.DataSource = Rooms.Roomlist;
            lstRooms.DataValueField = "Id";
            lstRooms.DataTextField = "RoomName";
            lstRooms.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Room.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Room.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteRoom.aspx");
        }
    }
}