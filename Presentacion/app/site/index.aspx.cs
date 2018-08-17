using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.app.site
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_message_error.CssClass = "";
            lbl_message_error.Text = "";
            lbl_message_error.Enabled = false;
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Equals(txt_pass.Text))
            {
                Response.Redirect("home.aspx");
            }
            else {
                lbl_message_error.Enabled = true;
                lbl_message_error.Text = "USUARIO Y CONTRASEÑA INVALIDOS"; 
            }
            
            //Server.Transfer("home.aspx", true);
        }
    }
}