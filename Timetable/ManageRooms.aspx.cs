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
            //Function to populate lstRooms with rooms and ddlSubjectSearch with the available subjects
            clsRoomCollection Rooms = new clsRoomCollection();

            foreach (string subject in Rooms.AvailableSubjects)
            {
                ddlSubjectSearch.Items.Add(subject);
            }

            //Sets default value, since "Any" will show all rooms
            ddlSubjectSearch.SelectedValue = "Any";
            
            lstRooms.Items.Clear();
            lstRooms.DataSource = Rooms.Roomlist;
            lstRooms.DataValueField = "Id";
            lstRooms.DataTextField = "RoomName";
            lstRooms.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Run when btnAdd is clicked
            //Redirects to Room page but sets the RoomID session object to
            //-1 to indicate that a new room is being added, rather than editing
            //an existing room
            Session["RoomID"] = -1;
            Session["Mode"] = "Admin";
            Response.Redirect("Room.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //Run when btnEdit is clicked
            //Redirects to Room page but sets the RoomID session object to
            //the ID of the selected room to indicate that an existing room is being edited, rather than adding
            //a new room
            //If no room is selected, show an error
            Int32 RoomID;
            if (lstRooms.SelectedIndex != -1)
            {
                RoomID = Convert.ToInt32(lstRooms.SelectedValue);
                Session["RoomID"] = RoomID;
                Session["Mode"] = "Admin";
                Response.Redirect("Room.aspx");
            }
            else { lblError.Text = "You must select a room to modify"; }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //Run when btnDelete is clicked
            //Redirects to DeleteRoom page but sets the RoomID session object to
            //the ID of the selected room to indicate which room needs to be deleted
            //If no room is selected, show an error
            Int32 RoomID;
            if (lstRooms.SelectedIndex != -1)
            {
                RoomID = Convert.ToInt32(lstRooms.SelectedValue);
                Session["RoomID"] = RoomID;
                Session["Mode"] = "Admin";
                Response.Redirect("DeleteRoom.aspx");
            }
            else { lblError.Text = "Select a room to delete"; }
        }

        protected void ddlSubjectSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Run when ddlSubject's selected item is changed
            //Used to filter lstRooms by subject depending on what is selected
            string Search = ddlSubjectSearch.SelectedValue;
            clsRoomCollection Rooms = new clsRoomCollection();
            Rooms.FilterBySubject(Search);
            lstRooms.Items.Clear();
            lstRooms.DataSource = Rooms.Roomlist;
            lstRooms.DataValueField = "Id";
            lstRooms.DataTextField = "RoomName";
            lstRooms.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            //Redirects back to AdminDefault
            Response.Redirect("AdminDefault.aspx");
        }

        protected void lstRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}