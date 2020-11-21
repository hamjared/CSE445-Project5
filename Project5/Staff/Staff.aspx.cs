using System;
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
            XDocument doc = XDocument.Load("~/App_Data/Staff.xml");
            //XDocument doc = XDocument.Load("C:/Users/Daniel/source/repos/CSE445-Project5/Project5/App_Data/Staff.xml");
            XElement staff = doc.Element("Staff");
            staff.Add(new XElement("User", new XElement("Username", txt_Username.Text), new XElement("Password", txt_Password.Text)));
            doc.Save("~/App_Data/Staff.xml");
            //doc.Save("C:/Users/Daniel/devTest/Staff.xml");
            txt_Username.Text = "";
            txt_Password.Text = "";
        }
    }
}