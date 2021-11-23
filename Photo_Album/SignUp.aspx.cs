using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Photo_Album
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        public SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = this.UnobtrusiveValidationMode;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\37157604\Downloads\Photo_Album\Photo_Album\Photo_Album\App_Data\PhotoAlbumDatabase.mdf;Integrated Security=True");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name, surname, cellphone, email, password, confirmPassw;
            name = txtName.Text;
            surname = txtSurname.Text;
            cellphone = txtCell.Text;
            email = txtEmail.Text;
            password = txtCreatePassword.Text;
            confirmPassw = txtConfirmPassword.Text;
           // int memberID = 0;

            if(txtCreatePassword.Text == txtConfirmPassword.Text)
            {
                con.Open();
                string insertQuery = "INSERT INTO Member VALUES ('" + name + "', '" + surname + "', '" + cellphone + "', '" + email + "', '" + password + "')";
                SqlCommand command = new SqlCommand(insertQuery, con);
                command.ExecuteNonQuery();
                Response.Write("Data was successfully added");
                con.Close();

                txtName.Text = "";
                txtSurname.Text = "";
                txtEmail.Text = "";
                txtCreatePassword.Text = "";
                txtConfirmPassword.Text = "";
                txtCell.Text = "";
            }
            else
            {
                Response.Write("Passwords don't match");
            }
        }
    }
}