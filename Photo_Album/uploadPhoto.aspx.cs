using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;

namespace Photo_Album
{
    public partial class uploadPhoto : System.Web.UI.Page
    {
        SqlConnection con;
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\37157604\Downloads\Photo_Album\Photo_Album\Photo_Album\App_Data\PhotoAlbumDatabase.mdf;Integrated Security=True";
        string photo;

        public int getMemberID()
        {
            WebForm1 form = new WebForm1();
            string username = form.username;
            //HttpCookie userInfo = Request.Cookies["userInfo"];
            //var value = Request.Cookies["Session"].Value;
            //string username = userInfo["username"];
            int returnValue = 0;
            con.Open();

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                string query = $"SELECT MemberID FROM Member Where Email = '{username}'";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        returnValue = reader.GetInt32(0);
                    }
                }
                connection.Close();
                return returnValue;
            };
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conStr);
            
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("Images/");
           // int photoID = 0;
            
            if (FileUpload1.HasFile)
            {
                string ext = Path.GetExtension(FileUpload1.FileName);
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif")
                {
                    FileUpload1.SaveAs(path + FileUpload1.FileName);
                    photo = "Photos/" + FileUpload1.FileName;
                    int size = FileUpload1.PostedFile.ContentLength;
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mmtt");

                    string query = "INSERT INTO Photo (Date, Photo, Size) VALUES ('" + date + "', '" + photo + "', '"+ size + "')";
                    con.Close();
                    SqlCommand command = new SqlCommand(query, con);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                   // Image1.ImageUrl = photo;

                    Response.Write("Image is successfully saved");
                }
                else
                {
                    Response.Write("Upload pictures only");
                }
            }
            else
            {
                Response.Write("Please select file");
            }
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPictures.aspx");
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT Photo From Photo WHERE PhotoID LIKE '" + txtSearch.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            GridView1.DataSource = dataSet;
            GridView1.DataBind();
            con.Close();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                string query = "DELETE FROM Photo WHERE PhotoID = '" + txtSearch.Text + "'";
                SqlCommand command = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();
                con.Close();
                Response.Write("Image is successfully removed");
            };
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {
                using (SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Photo", sqlConnection))
                {
                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                };
            };
        }
    }
}