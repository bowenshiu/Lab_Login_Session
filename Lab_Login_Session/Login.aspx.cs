﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text.Trim() == "")
        {
            lblPrompt.Text = "*";
            Label1.Text = "Please keyin User name!";
            return;
        }

        Session["uid"] = txtUserName.Text;

        if (Session["returnUrl"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Response.Redirect(Session["returnUrl"].ToString());
        }

    }
}