using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Discuss_Music
{
    public partial class Feed : System.Web.UI.Page
    {
        public string userName = "";
        public string insideBody = "";
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\documents\\visual studio 2017\\Projects\\Discuss-Music\\Discuss-Music\\App_Data\\CoolestDatabaseEver.mdf\";Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Id"]!=null)
            {
                //when I press on sign in
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM People WHERE Id = '" + Session["Id"] + "';";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    userName = reader.GetString(5);
                }
                else
                {
                    userName = "Guest";
                }
                reader.Close();
                connection.Close();
            }
            else
            {
                userName = "Guest";
            }

            if(Request.HttpMethod=="GET")
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command1 = connection.CreateCommand();
                command1.CommandText = "SELECT * FROM Articles ORDER BY Date DESC;";
                SqlDataReader reader1 = command1.ExecuteReader();
                List<int> writerIdList = new List<int>();
                while(reader1.Read())
                {
                    writerIdList.Add(reader1.GetInt32(3));
                }
                reader1.Close();

                List<string> writerUsernameList = new List<string>();
                foreach (int writerId in writerIdList)
                {
                    SqlCommand command2 = connection.CreateCommand();
                    command2.CommandText = "SELECT * FROM People WHERE Id = '" + writerId + "';";
                    SqlDataReader reader2 = command2.ExecuteReader();
                    if(reader2.Read())
                    {
                        writerUsernameList.Add(reader2.GetString(1));
                    }
                    else
                    {
                        writerUsernameList.Add("guest");
                    }
                    reader2.Close();
                }

                SqlDataReader reader3 = command1.ExecuteReader();
                int widthOfTitle = 150;
                int widthOfDate = 20;
                string title = "";
                int fontSize = 3;
                string color = "#006666"; //blueish
                string username = "";
                DateTime date = new DateTime();
                string content = "";
                int count = 0;

                while (reader3.Read())
                {
                    title = reader3.GetString(1);
                    content = reader3.GetString(2);
                    date = reader3.GetDateTime(4);
                    username = writerUsernameList[count];

                    insideBody += 
                    String.Format(@"<table> 
	                                    <col width="+ "{0}" + @">
                                        <col width = "+ "{1}" + @">
                                    <tr>
                                        <th>{2}<font size=" + "{3}" + " color="+ "{4}>" + @" /{5}</font></th>
                                        <th>" + "{6}" + @" </ th >
                                    </tr>
                                    <tr>
                                         <td colspan = 2> {7}</td>
                                    </tr>
                                    </table> <br>", widthOfTitle,widthOfDate,title,fontSize,color,username,date,content);
                    count++;
                }
                reader3.Close();
                connection.Close();
            }
            else
            {

            }
        }
    }
}