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
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\documents\\visual studio 2017\\Projects\\Discuss-Music\\Discuss-Music\\App_Data\\CoolestDatabaseEver.mdf\";Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
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
                connection.Close();
            }
    

        }
    }
}