using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientsideEncryption
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (string.IsNullOrEmpty(HDusername.Value))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Enter Username');", true);
                }
                else if (string.IsNullOrEmpty(HDPassword.Value))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Enter Password !');", true);
                }
                else
                {
                    var username = AESEncrytDecry.DecryptStringAES(HDusername.Value);

                    var password = AESEncrytDecry.DecryptStringAES(HDPassword.Value);

                    if (username == "keyError" && password == "keyError")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Not vaild login');", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('login successfully');", true);
                    }
                }

            }
        }

      


    }
}