using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Discuss_Music
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\CoolestDatabaseEver.mdf\";Integrated Security=True";
        public string message = "";

        protected void Page_Load(object sender, EventArgs e)
        {
                if (Request.HttpMethod == "POST")
                {
                    string username = Request.Form["username"];
                    string password = Request.Form["password"];
                    string name = Request.Form["name"];
                    DateTime birthday = DateTime.Parse(Request.Form["birthday"]);
                    string email = Request.Form["email"];
                    string phoneNumber = Request.Form["phoneNumber"];
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = String.Format("INSERT INTO People OUTPUT INSERTED.ID VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", username, password, phoneNumber, email, name, birthday.ToString("yyyy-MM-dd HH:mm:ss"));
                    try
                    {
                        int userId = (int)command.ExecuteScalar();
                        message = "Success!";
                        Session["Id"] = userId;
                        Response.Redirect("Feed.aspx");
                        
                    }
                    catch (SqlException)
                    {
                        message = "User already exist :(";
                    }
                    connection.Close();
                }
            }
        }
    }
