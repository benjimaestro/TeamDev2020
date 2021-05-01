using ClassLibrary;
using System;
using System.Web;

namespace T_Train_Front_office.Forms.Ticket_Type
{
    public partial class TicketType : System.Web.UI.Page
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
                //only staff is allowed to manage connections
                if (!isStaff)
                {
                    Response.Redirect("../User/Logout.aspx");
                }

                int ticketTypeId = 0;
                string action = "new";
                clsTicketType ATicketType = new clsTicketType();
                try
                {
                    ticketTypeId = Convert.ToInt32(Request.Params["typeId"]);
                    if (ticketTypeId > 0)
                    {
                        action = "edit";
                    }
                }
                catch
                {
                    //no ticket Type id or it is incorrect - new ticket Type form will be shown
                }

                switch (action)
                {
                    case "edit":
                        {
                            //fetch the details of the ticket type with id given
                            bool ticketTypeFound = ATicketType.FindTicketType(ticketTypeId);

                            //id valid
                            if (ticketTypeFound)
                            {
                                //Change the headers and buttons to show that we are editing
                                lblActionName.Text = "You are modifying this ticket type:";
                                btnSaveChanges.Text = "Save Changes";

                                //set value of the read-only fields to the details of the connection
                                lblId.Text = Convert.ToString(ATicketType.TicketTypeId);
                                lblName.Text = HttpUtility.HtmlAttributeEncode(ATicketType.TicketTypeName);
                                lblPrice.Text = Convert.ToString(ATicketType.TicketTypePrice);
                                lblRefundable.Text = ATicketType.TicketTypeRefundable ? "Refundable" : "Non-Refundable";
                                lblActive.Text = ATicketType.TicketTypeActive ? "Public" : "Private";

                                //Make all these fields visible
                                lblId.Visible = true;
                                lblName.Visible = true;
                                lblPrice.Visible = true;
                                lblStaticId.Visible = true;
                                lblRefundable.Visible = true;
                                lblActive.Visible = true;
                                lblStaticEditing.Visible = true;

                                //set value of the editable fields to the details of the ticket type
                                chkPublic.Checked = ATicketType.TicketTypeActive;
                                txtName.Text = ATicketType.TicketTypeName;
                                txtPrice.Text = Convert.ToString(ATicketType.TicketTypePrice);
                                chkRefundable.Checked = ATicketType.TicketTypeRefundable;

                                //Make the delete label and button visible
                                lblDelete.Visible = true;
                                btnDelTicketType.Visible = true;
                            }
                            else
                            {
                                //By default a new ticket type form is opened
                            }
                            break;
                        }
                    default:
                        {
                            //By default a new ticket type form is opened
                            break;
                        }
                }
            }
        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //redirect to ticket types
            Response.Redirect("TicketTypes.aspx");
        }

        protected void btnStaffDashboard_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/Logout.aspx");
        }

        protected void btnTicketType_Click(object sender, EventArgs e)
        {
            //create a collection class to store the ticket type
            clsTicketTypeCollection TicketTypeCollection = new clsTicketTypeCollection();

            //create a ticket type
            clsTicketType ATicketType = new clsTicketType();

            ATicketType.TicketTypeId = 0;

            try
            {
                //get the ticket type id
                ATicketType.TicketTypeId = Convert.ToInt32(Request.Params["typeId"]);

                ATicketType.TicketTypePrice = float.Parse(txtPrice.Text);
                if (txtName.Text == "" || txtPrice.Text == "")
                {
                    throw new Exception();
                }

                ATicketType.TicketTypeName = txtName.Text;
                ATicketType.TicketTypePrice = float.Parse(txtPrice.Text);
                ATicketType.TicketTypeRefundable = chkRefundable.Checked;
                ATicketType.TicketTypeActive = chkPublic.Checked;
                TicketTypeCollection.ThisTicketType = ATicketType;

                string action = "new";
                //add a new connection or modify the existing one
                if (ATicketType.TicketTypeId > 0)
                {
                    TicketTypeCollection.ModifyTicketType();
                    action = "edit";
                }
                else
                {
                    TicketTypeCollection.AddTicketType();
                }

                Response.Redirect("../User/ActionSuccess.aspx?origin=ttype&action=" + action);
            }
            catch
            {
                lblError.Visible = true;
            }
        }

        protected void btnDelTicketType_Click(object sender, EventArgs e)
        {
            //create a ticket type
            clsTicketType ATicketType = new clsTicketType();
            //get the connection id
            ATicketType.TicketTypeId = 0;
            try
            {
                ATicketType.TicketTypeId = Convert.ToInt32(Request.Params["typeId"]);
                if (ATicketType.TicketTypeId > 0)
                {
                    //delete an existing ticket type
                    clsTicketTypeCollection TicketTypeCollection = new clsTicketTypeCollection();
                    TicketTypeCollection.ThisTicketType = ATicketType;
                    TicketTypeCollection.DeleteTicketType();
                    Response.Redirect("../User/ActionSuccess.aspx?origin=ttype&action=delete");
                }
            }
            catch
            {
                lblError.Visible = true;
            }
        }
    }
}