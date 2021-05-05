using System;
using ClassLibrary;


namespace LaptopLoanProjectt
{
    public partial class LaptopStaffSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DisplayLaptopUsers();
            }
        }

       
        //function for populating the listbox 
        void DisplayLaptopUsers()
        {
            //Function to populate lstLaptopUsers with user accounts
            clsLaptopUserCollection LaptopUsers = new clsLaptopUserCollection();
            lstLaptopUsers.Items.Clear();
            lstLaptopUsers.DataSource = LaptopUsers.AllLaptopUsers;
            lstLaptopUsers.DataValueField = "LaptopUserId";
            lstLaptopUsers.DataTextField = "FullNameEmail";
            lstLaptopUsers.DataBind();
        }

        protected void lstLaptopUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void btnSearchStudent_Click(object sender, EventArgs e)
        {

        }
    }
}