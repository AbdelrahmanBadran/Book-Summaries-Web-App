﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteWAPP
{
    public partial class Site1 : System.Web.UI.MasterPage

    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //user_email.Text = Session["user_email"].ToString();
            //string userEmail = Session["user_email"] as string;

            if (Session["user_email"] != null)
            {
                Login.Style.Add("display", "none");
                SignUp.Style.Add("display", "none");
                //user.Text = (user_email != null) ? "Account" : "Guest";
            }
            else
            {
                Logout.Style.Add("display", "none");
            }

        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Summaries_Click(object sender, EventArgs e)
        {
            Response.Redirect("summaries.aspx");
        }

        protected void Create_Click(object sender, EventArgs e)
        {
            Response.Redirect("createSummaries.aspx");
        }

        protected void Contact_Click(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx");
        }

        protected void Profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            this.Session.Abandon();
            Response.Redirect("home.aspx");
        }

    }
}