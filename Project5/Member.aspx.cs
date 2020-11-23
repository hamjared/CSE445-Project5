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
            lbl_currentTime.Text = Global.currentTime;
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

        protected void bttn_weather_Click(object sender, EventArgs e)
        {
            String zcInput = txt_weather.Text; //get the zip code input from the weather text box
            int i = 0; //placeholder for parsing
            if (zcInput.Length != 5) //if the zip code is not 5 numbers long then it's not valid
            {
                lbl_weatherResults.Text = "Zip Code Length Must Be 5!";
                lbl_weatherResults.ForeColor = System.Drawing.Color.Red;
            }
            else if (!(int.TryParse(zcInput,out i))) {
                lbl_weatherResults.Text = "Zip Code Must Be A Numeric Value!";
                lbl_weatherResults.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                DanielServices.Service1Client myClient = new DanielServices.Service1Client();
                String[] result = myClient.Weather5day(zcInput);
                String resultText = result[0] + "," + result[1] + "," + result[2] + "," + result[3] + "," + result[4];
                lbl_weatherResults.Text = resultText;
                lbl_weatherResults.ForeColor = System.Drawing.Color.Black;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            VanessaService.Service2Client ytSearch = new VanessaService.Service2Client();

            string url = ytSearch.YTurls(txt_youtube.Text);
            string title = ytSearch.YTtitle(txt_youtube.Text);
            string description = ytSearch.YTdescription(txt_youtube.Text);

            Image1.ImageUrl = url;

            VideoTitle.Text = title;

        }

        protected void Get_Store_On_Click(object sender, EventArgs e)
        {
            JaredService.SmartHomeServicesClient findStoreService = new JaredService.SmartHomeServicesClient();
            string results = findStoreService.findNearestStore(storeName.Text, zipCode.Text);
            searchResultTextBox.Text = results;
        }
    }
}