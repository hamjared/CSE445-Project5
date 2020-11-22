using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using EncryptionDecryption_Project5;
using System.Web.Security;

namespace Project5
{
    
    public partial class MemberLogin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //IF button checked, save info to cookies
            bool auth = false;
            bool remember = false;

            XmlTextReader reader = new XmlTextReader(HttpContext.Current.Server.MapPath("App_Data/Member.xml"));

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

                        if (reader.Value.ToString() == Login1.UserName)
                        {
                            while (reader.Read())
                            {
                                if (reader.Name == "Password")
                                {
                                    reader.Read();

                                    //encrypt password to check
                                    EncryptionDecryption encrypter = new EncryptionDecryption();
                                    string pass = encrypter.Encryption(Login1.Password);

                                    if (reader.Value.ToString() == pass)
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
                if (Login1.RememberMeSet == true)
                {
                    remember = true;
                }
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName.ToString(), remember);
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