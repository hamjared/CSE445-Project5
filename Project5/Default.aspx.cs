using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Check cookies for user information, auto login if the cookies are available and not expired
        }

        protected void memberPageButton_Click(object sender, EventArgs e)
        {
            // Need to add redirect to member login page if user is not already logged in as a member
            Response.Redirect("~/Member.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Need to add redirect to staff login page if user is not already logged in as staff
            Response.Redirect("~/Staff/Staff.aspx");
        }
    }
}