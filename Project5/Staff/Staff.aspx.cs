﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace Project5
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //FormsAuthentication.RedirectToLoginPage();
        }

        protected void homePageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void bttn_AddStaff_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(HttpContext.Current.Server.MapPath("../App_Data/Staff.xml"));
            XElement staff = doc.Element("Staff");
            staff.Add(new XElement("User", new XElement("Username", txt_Username.Text), new XElement("Password", txt_Password.Text)));
            doc.Save(HttpContext.Current.Server.MapPath("../App_Data/Staff.xml"));
            txt_Username.Text = "";
            txt_Password.Text = "";
        }
    }
}