using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Project5
{
    public partial class Member : System.Web.UI.Page
    {

        private FormsAuthenticationTicket userTicket;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Implement our own cookies to auto authenticate members
            if (!this.isMemberLoggedIn())
            {
                
                Response.Redirect("~/MemberLogin.aspx");
            }
        }

        protected void homePageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        private bool isMemberLoggedIn()
        {
            try
            {
                HttpCookie authCookie = Request.Cookies.Get("memberCookie");
                if(authCookie == null)
                {
                    return false;
                }
                userTicket = FormsAuthentication.Decrypt(authCookie.Value);
            } catch (ArgumentException)
            {
                return false;
            }
            
            if(userTicket == null)
            {
                return false;
            }
            return true;
                 
        }
    }
}