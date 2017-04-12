using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Discuss_Music
{
    public partial class Edit : System.Web.UI.Page
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\CoolestDatabaseEver.mdf\";Integrated Security=True";
        public string message = "";
        public string username = "";
        public string password = "";
        public string name = "";
        public DateTime birthday = DateTime.Now;
        public string email = "";
        public string phoneNumber = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.HttpMethod == "POST")
            {
                username = Request.Form["username"];
                password = Request.Form["password"];
                name = Request.Form["name"];
                birthday = DateTime.Parse(Request.Form["birthday"]);
                email = Request.Form["email"];
                phoneNumber = Request.Form["phoneNumber"];
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = String.Format("UPDATE People SET Username = '{0}',Password = '{1}',PhoneNumber = '{2}',Email = '{3}',Name = '{4}',Birthday = '{5}' WHERE Id = '" + Session["Id"] + "';", username, password, phoneNumber, email, name, birthday);
                try
                {
                    command.ExecuteNonQuery();
                    message = "Success!";
                    Response.Redirect("MyProfile.aspx");

                }
                catch (SqlException)
                {
                    message = "User already exist :(";
                }
                connection.Close();
            }

            else if(Request.HttpMethod == "GET")
            {
                username = "Username";
                password = "Password";
                phoneNumber = "Phone Number";
                email = "Email";
                name = "Guest";
                birthday = DateTime.Now;

                if (Session["Id"] != null)
                {
                    //when I press on sign in
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM People WHERE Id = '" + Session["Id"] + "';";
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        username = reader.GetString(1);
                        password = reader.GetString(2);
                        phoneNumber = reader.GetString(3);
                        email = reader.GetString(4);
                        name = reader.GetString(5);
                        birthday = reader.GetDateTime(6);
                    }
                    reader.Close();
                }

            }
        }
    }







}