using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Xml;

namespace Project5
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool authSuccessful = false;
            authSuccessful = searchStaffXML(Login1.UserName, Login1.Password);
            if (authSuccessful)
            {
                e.Authenticated = true;
                Response.Redirect("Member.aspx");
            }
            else
            {
                e.Authenticated = false;
                Response.Redirect("Default.aspx");
            }
            FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
        }

        private bool searchStaffXML(string uname, string pass)
        {
            XmlTextReader reader = new XmlTextReader("C:/Users/Daniel/source/repos/CSE445-Project5/Project5/App_Data/Staff.xml");
            if (reader == null)
            {
                return false;
            }
            while (reader.Read())
            {
                if (reader.Name == "Username")
                {
                    reader.Read();
                    if (reader.Value.ToString() == uname)
                    {
                        while (reader.Read())
                        {
                            if (reader.Name == "Password")
                            {
                                reader.Read();
                                if (reader.Value.ToString() == pass)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }

}