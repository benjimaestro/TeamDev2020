using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace T_Train_Front_office.Forms.Connection
{
    public partial class Connection : System.Web.UI.Page
    {
        clsConnection AConnection = new clsConnection();
        int connectionId = 0;
        string action = "new";
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!IsPostBack)
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
                if(!isStaff)
                {
                    Response.Redirect("../User/Logout.aspx");
                }

                //Fill the time dropdown list
                for (int hour = 0; hour < 24; ++hour)
                {
                    for (int minutes = 0; minutes < 60; minutes += 15)
                    {
                        //format the hour
                        string hourToAdd = Convert.ToString(hour);
                        hourToAdd = hourToAdd.Length == 1 ? ("0" + hourToAdd) : hourToAdd;

                        //format the minutes
                        string minutesToAdd = Convert.ToString(minutes);
                        minutesToAdd = minutesToAdd.Length == 1 ? "00" : minutesToAdd;

                        //create a list item
                        ListItem timeItem = new ListItem();
                        timeItem.Text = hourToAdd + ":" + minutesToAdd;
                        timeItem.Value = hourToAdd + ":" + minutesToAdd;

                        //add the time to the dropdown list
                        ddlTime.Items.Add(timeItem);
                    }
                }

                //Fill the ticket type dropdown list
                clsTicketTypeCollection TTypeManager = new clsTicketTypeCollection();
                TTypeManager.MyTicketTypes = TTypeManager.ListTicketTypes();
                for(int i = 0; i < TTypeManager.Count; ++i)
                {
                    //only use public ticket types
                    if(TTypeManager.MyTicketTypes[i].TicketTypeActive == true)
                    {
                        ListItem ticketTypeItem = new ListItem();
                        ticketTypeItem.Text = TTypeManager.MyTicketTypes[i].TicketTypeName;
                        ticketTypeItem.Value = Convert.ToString(TTypeManager.MyTicketTypes[i].TicketTypeId);
                        ddlTicketType.Items.Add(ticketTypeItem);
                    }
                }

                try
                {
                    connectionId = Convert.ToInt32(Request.Params["connId"]);
                    if (connectionId > 0)
                    {
                        action = "edit";
                    }
                }
                catch
                {
                    //no connection id or it is incorrect - new connection form will be shown
                }

                switch (action)
                {
                    case "edit":
                        {
                            //fetch the details of the connection with id given
                            bool connectionFound = AConnection.FindConnection(connectionId);

                            //id valid
                            if (connectionFound)
                            {
                                //Change the headers and buttons to show that we are editing
                                lblActionName.Text = "Change connection details:";
                                btnSaveConnection.Text = "Save changes";
                                lblStaticModLimit.Text = "Tickets remaining:";
                                lblTicketLimit.Text = "Tickets remaining:";

                                //set value of the read-only fields to the details of the connection
                                lblModId.Text = Convert.ToString(AConnection.ConnectionId);
                                lblModLocation.Text = HttpUtility.HtmlAttributeEncode(
                                    $"{AConnection.ConnectionStartStation} - {AConnection.ConnectionEndStation}"
                                );
                                lblModDate.Text = AConnection.ConnectionDate.ToString("dd/MM/yyyy");
                                lblModTime.Text = AConnection.ConnectionTime.ToString(@"hh\:mm");
                                lblModPublic.Text = AConnection.ConnectionActive ? "Active" : "Private";
                                lblModTickets.Text = Convert.ToString(AConnection.ConnectionTicketLimit);
                                //lblModAdded.Text = Convert.ToString(AConnection.ConnectionAddedAt);

                                //Make all these fields visible
                                lblModifyHeader.Visible = true;
                                lblModAdded.Visible = true;
                                lblModDate.Visible = true;
                                lblModTime.Visible = true;
                                lblStaticId.Visible = true;
                                lblModId.Visible = true;
                                lblModLocation.Visible = true;
                                lblStaticModLimit.Visible = true;
                                lblModTickets.Visible = true;
                                lblModPublic.Visible = true;

                                //set value of the editable fields to the details of the connection
                                ddlFrom.SelectedValue = AConnection.ConnectionStartStation;
                                ddlTo.SelectedValue = AConnection.ConnectionEndStation;
                                txtDate.Text = AConnection.ConnectionDate.ToString("dd/MM/yyyy");
                                ddlTime.SelectedValue = AConnection.ConnectionTime.ToString(@"hh\:mm");
                                txtTicketLimit.Text = Convert.ToString(AConnection.ConnectionTicketLimit);
                                chkConnActive.Checked = AConnection.ConnectionActive;
                                ddlTicketType.SelectedValue = Convert.ToString(AConnection.TicketTypeId);

                                //Make the delete label and button visible
                                lblDelete.Visible = true;
                                btnDelConnection.Visible = true;
                                btnGoTType.Visible = true;
                            }
                            else
                            {
                                //By default a new connection is added
                                lblActionName.Text = "Add connection:";
                                btnSaveConnection.Text = "Add connection";
                                lblStaticModLimit.Text = "Ticket limit:";
                            }
                            break;
                        }
                    default:
                        {
                            //By default a new connection is added
                            lblActionName.Text = "Add connection:";
                            btnSaveConnection.Text = "Add connection";
                            lblStaticModLimit.Text = "Ticket limit:";
                            break;
                        }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("../Default.aspx");
        }

        protected void btnStaffDashboard_Click(object sender, EventArgs e)
        {
            //redirect to the staff dashboard
            Response.Redirect("../StaffDashboard.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //create a collection class to store the connection
            clsConnectionCollection ConnectionCollection = new clsConnectionCollection();

            //get the connection id
            AConnection.ConnectionId = 0;
            try
            {
                AConnection.ConnectionId = Convert.ToInt32(Request.Params["connId"]);
            }
            catch
            {
                //connection id equals 0 which means we create a new connection
            }
            AConnection.ConnectionActive = chkConnActive.Checked;
            AConnection.ConnectionDate = Convert.ToDateTime(txtDate.Text);
            AConnection.ConnectionEndStation = ddlTo.SelectedValue;
            AConnection.ConnectionStartStation = ddlFrom.SelectedValue;
            AConnection.ConnectionTime = TimeSpan.Parse(ddlTime.SelectedValue);
            AConnection.ConnectionTicketLimit = Convert.ToInt32(txtTicketLimit.Text);
            AConnection.TicketTypeId = Convert.ToInt32(ddlTicketType.SelectedValue);
            ConnectionCollection.ThisConnection = AConnection;

            //add a new connection or modify the existing one
            if (AConnection.ConnectionId > 0)
            {
                ConnectionCollection.ModifyConnection();
                action = "edit";
            }
            else
            {
                ConnectionCollection.AddConnection();
            }

            Response.Redirect("../User/ActionSuccess.aspx?origin=conn&action="+action);
        }

        protected void btnDelConnection_Click(object sender, EventArgs e)
        {
            //get the connection id
            AConnection.ConnectionId = 0;
            try
            {
                AConnection.ConnectionId = Convert.ToInt32(Request.Params["connId"]);
                if(AConnection.ConnectionId > 0)
                {
                    //delete an existing connection
                    clsConnectionCollection ConnectionCollection = new clsConnectionCollection();
                    ConnectionCollection.ThisConnection = AConnection;
                    ConnectionCollection.DeleteConnection();
                    Response.Redirect("../User/ActionSuccess.aspx?origin=conn&action=delete");
                }
            }
            catch
            {
                //failure
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to logout
            Response.Redirect("../User/Logout.aspx");
        }

        protected void btnPick_Click(object sender, EventArgs e)
        {
            //Show the datepicker
            dtpDate.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //Date in a datepicker is picked
            DateTime date = dtpDate.SelectedDate;
            txtDate.Text = Convert.ToString(date).Substring(0, 10);
            dtpDate.Visible = false;
        }

        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            //Redirect back to connections page
            Response.Redirect("Connections.aspx");
        }

        protected void btnGoTType_Click(object sender, EventArgs e)
        {
            //Redirect to a new ticket type add page
            Response.Redirect("../TicketType/TicketType.aspx");
        }
    }
}