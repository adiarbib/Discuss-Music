using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Discuss_Music
{
    public partial class Profile : System.Web.UI.Page
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\CoolestDatabaseEver.mdf\";Integrated Security=True";
        public string insideBody = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.HttpMethod == "POST")
            {
                string search = Request.Form["search"];
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM People WHERE Username = '" + search + "';";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string username1 = reader.GetString(1);
                    string phoneNumber = reader.GetString(3);
                    string email = reader.GetString(4);
                    string name = reader.GetString(5);
                    DateTime birthday = reader.GetDateTime(6);

                    insideBody +=
                    String.Format(@"<h4>Name: "+"{0}"+@"</h4>
                                    <h4>Username: "+"{1}"+@"</h4>
                                    <h4>Phone Number: "+"{2}"+@"</h4>
                                    <h4>Email: "+"{3}"+@"</h4>
                                    <h4>Birthday: "+"{4}"+@"</h4><br/>"
                    , name, username1, phoneNumber, email, birthday);
                }
                else
                {
                    insideBody += "<p>Couldn't find user with this username, You should check your spelling.</p><br />";
                }
                reader.Close();

                SqlCommand command2 = connection.CreateCommand();
                command2.CommandText = "SELECT * FROM Articles WHERE Title = '" + search + "';";
                SqlDataReader reader2 = command2.ExecuteReader();
                int writerId = 0;
                if(reader2.Read())
                {
                    writerId = reader2.GetInt32(3);
                }
                reader2.Close();
                SqlCommand command1 = connection.CreateCommand();
                command1.CommandText = "SELECT * FROM People WHERE Id = '" + writerId + "';";
                SqlDataReader reader1 = command1.ExecuteReader();
                string username = "";
                if(reader1.Read())
                {
                    username = reader1.GetString(1);
                }
                reader1.Close();
                SqlDataReader reader3 = command2.ExecuteReader();
                if (reader3.Read())
                {
                    int widthOfTitle = 150;
                    int widthOfDate = 20;
                    string title = search;
                    int fontSize = 3;
                    string color = "#006666"; //blueish
                    string content = reader3.GetString(2);
                    DateTime date = reader3.GetDateTime(4);

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
                else
                {
                    insideBody += "<p>Couldn't find an article with this title, You should check your spelling.</p><br />";

                }
                reader3.Close();

                connection.Close();
            }
        }
    }
}