using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SRVTextToImage;
using System.Drawing;
using System.Drawing.Imaging;
namespace Project5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CaptchaRandomImage CI = new CaptchaRandomImage();

            string captcha = CI.GetRandomString(5);

            Session["cText"] = captcha;

            CI.GenerateImage(captcha, 250, 75, Color.DarkBlue, Color.FloralWhite);

            this.Response.Clear();
            this.Response.ContentType = "image/jpeg";
            CI.Image.Save(this.Response.OutputStream, ImageFormat.Jpeg);

            CI.Dispose();
        }
    }
}
    