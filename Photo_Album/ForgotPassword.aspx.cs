using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Photo_Album
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCreatePassw.Text.ToString() == txtConfirmPassw.Text.ToString())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\37157604\Downloads\Photo_Album\Photo_Album\Photo_Album\App_Data\PhotoAlbumDatabase.mdf;Integrated Security=True");
                con.Open();
                string updatePassword = "UPDATE Member SET password = '" + txtConfirmPassw.Text + "' WHERE email = '" + txtUsername.Text + "'";
                SqlCommand command = new SqlCommand(updatePassword, con);
                command.ExecuteNonQuery();
                con.Close();
                Response.Write("Password is reseted");
            }
            else
            {
                Response.Write("Passwords don't match");
            }
           
        }


        protected void btnBack_Click1(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}