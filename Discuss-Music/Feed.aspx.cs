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
        }
    }
}