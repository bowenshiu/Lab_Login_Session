﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secret : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string s = Session["uid"].ToString();
        //Label1.Text = s;
        if (Session["uid"] == null)
        {
            Session["returnUrl"] = "Secret.aspx";
            Response.Redirect("Login.aspx");
            return;
        }
    }
}