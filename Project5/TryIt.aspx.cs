using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptionDecryption_Project5;

namespace Project5
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttn_encrypt_Click(object sender, EventArgs e)
        {
            EncryptionDecryption myEncrypter = new EncryptionDecryption();
            string result = myEncrypter.Encryption(txt_encrypt.Text);
            lbl_encryptResults.Text = result;
        }

        protected void bttn_decrypt_Click(object sender, EventArgs e)
        {
            EncryptionDecryption myDecrypter = new EncryptionDecryption();
            string result = myDecrypter.Decryption(txt_decrypt.Text);
            lbl_decryptResults.Text = result;
        }
    }
}