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
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\documents\\visual studio 2017\\Projects\\Discuss-Music\\Discuss-Music\\App_Data\\CoolestDatabaseEver.mdf\";Integrated Security=True";
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
                    
                }
                else
                {
                    reader.Close();
                }

                SqlCommand command2 = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Articles WHERE Title = '" + search + "';";
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.Read())
                {
                    int widthOfTitle = 150;
                    int widthOfDate = 20;
                    string title = "";
                    int fontSize = 3;
                    string color = "#006666"; //blueish
                    DateTime date = new DateTime();
                    string content = "";
                    title = reader2.GetString(1);
                    content = reader2.GetString(2);
                    date = reader2.GetDateTime(4);

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

                }

                connection.Close();
            }
        }
    }
}