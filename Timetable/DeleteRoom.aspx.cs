﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Timetable
{
    public partial class DeleteRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRooms.aspx");
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageRooms.aspx");
        }
    }
}