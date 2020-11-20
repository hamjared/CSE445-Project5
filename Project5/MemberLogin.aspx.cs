using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Project5
{
    
    public partial class MemberLogin : System.Web.UI.Page
    {
        static bool verified = false;

        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //IF button checked, save info to cookies
            bool auth = false;

            XmlTextReader reader = new XmlTextReader("~/App_Data/Member.xml");

            if (reader == null)
            {
                auth = false;
            }
            else
            {
                while (reader.Read())
                {
                    if (reader.Name == "Username")
                    {
                        reader.Read();

                        //encrypt username to check

                        if (reader.Value.ToString() == Login1.UserName)
                        {
                            while (reader.Read())
                            {
                                if (reader.Name == "Password")
                                {
                                    reader.Read();

                                    //encrypt password to check

                                    if (reader.Value.ToString() == Login1.Password)
                                    {
                                        auth = true;
                                    }
                                }

                            }
                        }
                        else
                            auth = false;
                    }
                }

            }

            if(auth)
            {
                e.Authenticated = true;
                Response.Redirect("Member.aspx");
            }
            else
            {
                e.Authenticated = false;
                Response.Redirect("Default.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberSignUp.aspx");

        }
    }
}