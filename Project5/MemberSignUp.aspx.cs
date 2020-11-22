using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptionDecryption_Project5;

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
            if(Password.Text == ConfirmPassword.Text && Password.Text != null)
            {
                if (Session["cText"].ToString() == TextBox1.Text)
                {
                    //add user to XML database
                    //after encryption.

                    string password = EncryptionDecryption.Encryption(Password.Text);



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


    }
}