using ClassLibrary;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Ticket_Type
{
    public partial class TicketTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //check if the user is a staff member
                bool isStaff = false;
                if (Session["customerLoggedIn"] != null)
                {
                    if (Convert.ToBoolean(Session["customerLoggedIn"]) == true)
                    {
                        if (Session["customerIsStaff"] != null)
                        {
                            if (Convert.ToBoolean(Session["customerIsStaff"]) == true)
                            {
                                isStaff = true;
                            }
                        }
                    }
                }

                //if they are not staff, redirect them to logout
                //only staff is allowed to filter ticket types
                if (!isStaff)
                {
                    Response.Redirect("../User/Logout.aspx");
                }
            }
        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/Logout.aspx");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            //first specify the filtering parameters
            try
            {
                //first get the parameters from text
                string typeName = txtTypeName.Text;
                string maxPrice = txtTypePrice.Text != "" ? txtTypePrice.Text : "999.99";
                bool onlyRefundable = chkOnlyRefundable.Checked;

                //next assign the parameters
                clsTicketType ATicketType = new clsTicketType();
                ATicketType.TicketTypeName = typeName;
                ATicketType.TicketTypePrice = float.Parse(maxPrice);
                ATicketType.TicketTypeRefundable = onlyRefundable;

                //if they are valid, filter ticket types
                if (typeName != "" || maxPrice != "999.99" || onlyRefundable != false)
                {
                    lblStaticHeader.Visible = true;

                    clsTicketTypeCollection TTypeManager = new clsTicketTypeCollection();
                    TTypeManager.MyTicketTypes = TTypeManager.FilterTicketTypes(ATicketType);

                    //there are no ticket types returned
                    if (TTypeManager.Count == 0)
                    {
                        lblStaticNoneFound.Visible = true;
                        lblError.Visible = false;
                        btnManageType.Visible = false;
                        lblTypeSelected.Visible = false;
                        lstTicketTypes.Visible = false;
                    }
                    else
                    {
                        //clear the list in case any items remained
                        lstTicketTypes.Items.Clear();

                        //show the default controls
                        lstTicketTypes.Visible = true;
                        btnManageType.Visible = true;
                        lblError.Visible = false;
                        lblStaticNoneFound.Visible = false;

                        //for each ticket type, add it into the list
                        for (int i = 0; i < TTypeManager.Count; ++i)
                        {
                            ListItem ATicketTypeItem = new ListItem();
                            string refundable = TTypeManager.MyTicketTypes[i].TicketTypeRefundable ? "Refundable" : "Non-Refundable";
                            string available = TTypeManager.MyTicketTypes[i].TicketTypeActive ? "Active" : "Private";
                            ATicketTypeItem.Text = TTypeManager.MyTicketTypes[i].TicketTypeName
                                + "    ||    " + TTypeManager.MyTicketTypes[i].TicketTypePrice
                                + "    ||    " + refundable + "    ||    " + available;
                            ATicketTypeItem.Value = Convert.ToString(TTypeManager.MyTicketTypes[i].TicketTypeId);
                            lstTicketTypes.Items.Add(ATicketTypeItem);
                        }
                    }
                }
                else
                {
                    //if invalid, display an error message on screen
                    lblError.Visible = true;
                    lblError.Text = "Entered data is invalid, please try again.";
                }
            }
            catch
            {
                //if invalid, display an error message on screen
                lblError.Visible = true;
                lblError.Text = "Entered data is invalid, please try again.";
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            //get the selected ticket type's id
            string selectedValue = lstTicketTypes.SelectedValue;
            //check if the selection was made
            if (selectedValue == "")
            {
                //if it was not, show an error
                lblTypeSelected.Visible = true;
            } //if it was, redirect
            else Response.Redirect("TicketType.aspx?typeId=" + lstTicketTypes.SelectedValue);
        }

        protected void btnAllTypes_Click(object sender, EventArgs e)
        {
            //clear the list in case any items remained
            lstTicketTypes.Items.Clear();

            //show the default controls
            lstTicketTypes.Visible = true;
            btnManageType.Visible = true;
            lblError.Visible = false;
            lblStaticNoneFound.Visible = false;
            lblStaticHeader.Visible = true;

            //get all ticket types
            clsTicketTypeCollection TTypeManager = new clsTicketTypeCollection();
            TTypeManager.MyTicketTypes = TTypeManager.ListTicketTypes();

            //for each ticket type, add it into the list
            for (int i = 0; i < TTypeManager.Count; ++i)
            {
                ListItem ATicketTypeItem = new ListItem();
                string refundable = TTypeManager.MyTicketTypes[i].TicketTypeRefundable ? "Refundable" : "Non-Refundable";
                string available = TTypeManager.MyTicketTypes[i].TicketTypeActive ? "Active" : "Private";
                ATicketTypeItem.Text = TTypeManager.MyTicketTypes[i].TicketTypeName
                    + "    ||    " + TTypeManager.MyTicketTypes[i].TicketTypePrice
                    + "    ||    " + refundable + "    ||    " + available;
                ATicketTypeItem.Value = Convert.ToString(TTypeManager.MyTicketTypes[i].TicketTypeId);
                lstTicketTypes.Items.Add(ATicketTypeItem);
            }
        }
    }
}