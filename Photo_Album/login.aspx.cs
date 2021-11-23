using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Photo_Album
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // public SqlConnection con;
        //public DataSet ds;
        //string conStr;
        public string username { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie userInfo = new HttpCookie("userInfo");
            userInfo["Username"] = txtUsername.Text;
            userInfo["Password"] = txtPassword.Text;
            Response.Cookies.Add(userInfo);
            userInfo.Expires = DateTime.Now.AddMinutes(45);
            username = txtUsername.Text;
            SqlConnection conStr = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\37157604\Downloads\Photo_Album\Photo_Album\Photo_Album\App_Data\PhotoAlbumDatabase.mdf;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Count(*) FROM Member WHERE Email = '" + userInfo["username"] + "' and Password = '" + userInfo["Password"] + "'", conStr);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() == "1")
            {
                Response.Redirect("uploadPhoto.aspx");
            }
            else
            {
                Response.Write("Invalid password & Username");
            }
                       
        }
    }
}