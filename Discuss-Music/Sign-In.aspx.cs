using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Discuss_Music
{
    public partial class Sign_In : System.Web.UI.Page
    {
        public string message = "";
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\CoolestDatabaseEver.mdf\";Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                string username = Request.Form["username"];
                string password = Request.Form["password"];
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM People WHERE Username = '" + username + "';";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if(reader.GetString(2)==password)
                    {
                        message = "Success!";
                        Session["Id"] = reader.GetInt32(0);
                        Response.Redirect("Feed.aspx");
                    }
                    else
                    {
                        message = "username or password do not match, please try again.";
                    }
                }
                else
                {
                    message = "username or password do not match, please try again.";
                }
                reader.Close();
                connection.Close();
            }
        }
    }
}