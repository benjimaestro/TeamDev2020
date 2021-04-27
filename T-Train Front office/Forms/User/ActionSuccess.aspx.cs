using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.User
{
    public partial class ActionSuccess : System.Web.UI.Page
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
                                btnStaffDashboard.Visible = true;
                            }
                        }
                    }
                }

                string origin = Request.Params["origin"];
                string action = Request.Params["action"];

                switch (origin)
                {
                    case "conn":
                        {
                            switch (action)
                            {
                                case "delete":
                                    {
                                        lblStaticDelSuccess.Text = "Success! The connection has been deleted.";
                                        lblStaticDelSuccess.Visible = true;
                                        break;
                                    }
                                case "edit":
                                    {
                                        lblStaticModSuccess.Text = "Success! The connection has been modified.";
                                        lblStaticModSuccess.Visible = true;
                                        break;
                                    }
                                case "new":
                                    {
                                        lblStaticAddSuccess.Text = "Success! New connection has been added.";
                                        lblStaticAddSuccess.Visible = true;
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case "ticket":
                        {
                            switch (action)
                            {
                                case "cancelled":
                                    {
                                        lblStaticTicketCancelled.Visible = true;
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case "payment":
                        {
                            switch (action)
                            {
                                case "success":
                                    {
                                        lblPaymentSuccess.Visible = true;
                                        break;
                                    }
                                case "failure":
                                    {
                                        lblPaymentFailure.Visible = true;
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case "ttype":
                        {
                            switch (action)
                            {
                                case "delete":
                                    {
                                        lblStaticDelSuccess.Text = "Success! The ticket type has been deleted.";
                                        lblStaticDelSuccess.Visible = true;
                                        break;
                                    }
                                case "edit":
                                    {
                                        lblStaticModSuccess.Text = "Success! The ticket type has been modified.";
                                        lblStaticModSuccess.Visible = true;
                                        break;
                                    }
                                case "new":
                                    {
                                        lblStaticAddSuccess.Text = "Success! New ticket type has been added.";
                                        lblStaticAddSuccess.Visible = true;
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    default:
                        {
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

        protected void Button10_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //redirect to my tickets list
            Response.Redirect("../Ticket/MyTickets.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //redirect to my account settings
            Response.Redirect("Settings.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("Logout.aspx");
        }
    }
}