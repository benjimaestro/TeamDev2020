using ClassLibrary;
using System;

namespace T_Train_Front_office.Forms
{
    public partial class StaffDashboard : System.Web.UI.Page
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
                //only staff is allowed to enter staff dashboard
                if (!isStaff)
                {
                    Response.Redirect("../User/Logout.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("Default.aspx");
        }

        protected void btnTickets_Click(object sender, EventArgs e)
        {
            //redirect to my tickets list
            Response.Redirect("Ticket/MyTickets.aspx");
        }

        protected void btnSettings_Click(object sender, EventArgs e)
        {
            //redirect to my account settings
            Response.Redirect("User/Settings.aspx");
        }

        protected void btnFindConnection_Click(object sender, EventArgs e)
        {
            //redirect to a particular connection
            string connectionIdText = txtConnId.Text;
            int connectionId = 0;
            try
            {
                connectionId = Convert.ToInt32(connectionIdText);
                clsConnection AConnection = new clsConnection();
                bool found = AConnection.FindConnection(connectionId);
                if(found)
                {
                    Response.Redirect("Connection/Connection.aspx?connId="+connectionId);
                }
                else
                {
                    throw new System.Exception("");
                }
            }
            catch
            {
                //id not found or invalid - display error message
                lblErrorConn.Visible = true;
            }
            
        }

        protected void btnConnections_Click(object sender, EventArgs e)
        {
            //redirect to all connections screen
            Response.Redirect("Connection/Connections.aspx");
        }

        protected void btnAddConnection_Click(object sender, EventArgs e)
        {
            //redirect to add new connection screen
            Response.Redirect("Connection/Connection.aspx");
        }

        protected void btnFindTicketType_Click(object sender, EventArgs e)
        {
            //redirect to a particular ticket type
            string ticketTypeIdText = txtTypeId.Text;
            int ticketTypeId = 0;
            try
            {
                ticketTypeId = Convert.ToInt32(ticketTypeIdText);
                clsTicketType ATicketType = new clsTicketType();
                bool found = ATicketType.FindTicketType(ticketTypeId);
                if (found)
                {
                    Response.Redirect("TicketType/TicketType.aspx?typeId=" + ticketTypeId);
                }
                else
                {
                    throw new System.Exception("");
                }
            }
            catch
            {
                //id not found or invalid - display error message
                lblErrorTType.Visible = true;
            }
        }

        protected void btnTicketTypes_Click(object sender, EventArgs e)
        {
            //redirect to all ticket types screen
            Response.Redirect("TicketType/TicketTypes.aspx");
        }

        protected void btnAddTicketType_Click(object sender, EventArgs e)
        {
            //redirect to add new ticket type
            Response.Redirect("TicketType/TicketType.aspx");
        }

        protected void btnFilterCustomers_Click(object sender, EventArgs e)
        {
            //redirect to filtered customer list
            Response.Redirect("Customer/Customers.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("User/Logout.aspx");
        }
    }
}