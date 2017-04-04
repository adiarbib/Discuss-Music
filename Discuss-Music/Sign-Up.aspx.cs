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
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\documents\\visual studio 2017\\Projects\\Discuss-Music\\Discuss-Music\\App_Data\\CoolestDatabaseEver.mdf\";Integrated Security=True";
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


                    //when I press on submit
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = String.Format("INSERT INTO People OUTPUT INSERTED.ID VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", username, password, phoneNumber, email, name, birthday);
                    //if unique it may throw an exception

                    try
                    {
                        int userId = (int)command.ExecuteScalar();
                        message = "Success!";
                        Response.Redirect("Home.aspx");
                        Session["Id"] = userId;

                    }

                    catch (SqlException)
                    {
                        //should write beside the username that the user already exist
                        message = "User already exist :(";
                    }

                    connection.Close();


                }



            }
        }
    }
