using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Discuss_Music
{
    public partial class MyProfile : System.Web.UI.Page
    {
        public string username;
        public string password;
        public string phoneNumber;
        public string email;
        public string name;
        public DateTime birthday;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\CoolestDatabaseEver.mdf\";Integrated Security=True";
        public string insideBody = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "GET")
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

                    SqlCommand command1 = connection.CreateCommand();
                    command1.CommandText = "SELECT * FROM Articles WHERE WriterId = '" + Session["Id"] + "' ORDER BY Date DESC;";
                    SqlDataReader reader3 = command1.ExecuteReader();
                    int widthOfTitle = 150;
                    int widthOfDate = 20;
                    string title = "";
                    int fontSize = 3;
                    string color = "#006666"; //blueish
                    DateTime date = new DateTime();
                    string content = "";


                    while (reader3.Read())
                    {
                        title = reader3.GetString(1);
                        content = reader3.GetString(2);
                        date = reader3.GetDateTime(4);

                        insideBody +=
                        String.Format(@"<table> 
	                                    <col width=" + "{0}" + @">
                                        <col width = " + "{1}" + @">
                                    <tr>
                                        <th>{2}<font size=" + "{3}" + " color=" + "{4}>" + @" /{5}</font></th>
                                        <th>" + "{6}" + @" </ th >
                                    </tr>
                                    <tr>
                                         <td colspan = 2> {7}</td>
                                    </tr>
                                    </table> <br>", widthOfTitle, widthOfDate, title, fontSize, color, username, date, content);

                    }
                    reader3.Close();
                    connection.Close();
                }
            }

            else if(Request.HttpMethod == "POST")
            {

            }

        }
    }
}