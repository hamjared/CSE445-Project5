using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptionDecryption_Project5;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Schema;


namespace Project5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text != null)
            {
                if (Password.Text == ConfirmPassword.Text && Password.Text != null)
                {
                    if (Session["cText"].ToString() == TextBox1.Text)
                    {
                        //add user to XML database
                        //after encryption.

                        string encrypted_password = EncryptionDecryption.Encryption(Password.Text);

                        XmlWriterSettings settings = new XmlWriterSettings();
                        settings.Indent = true;
                        settings.NewLineOnAttributes = true;

                        XmlDocument xref = new XmlDocument();
                        xref.Load(HttpContext.Current.Server.MapPath("App_Data/Member.xml"));

                        XPathNavigator nav = xref.CreateNavigator();

                        nav.MoveToChild("Members", "");
                        XmlWriter writer = nav.AppendChild();

                        writer.WriteStartElement("User");
                        writer.WriteElementString("Username", UserName.Text);
                        writer.WriteElementString("Password", encrypted_password);
                        writer.WriteEndElement();
                        writer.WriteEndElement();

                        writer.Close();


                        Response.Redirect("~/Member.aspx");


                    }
                    else
                    {
                        errorLabel.Visible = true;
                        errorLabel.Text = "Validation incorrect.";
                    }
                }
                else
                {
                    //show pw do not match
                    errorLabel.Visible = true;
                    errorLabel.Text = "Passwords Must Match!";
                }
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Username cannot be blank";
            }
        }


    }
}