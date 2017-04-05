using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Discuss_Music
{
    public partial class NewArticle : System.Web.UI.Page
    {
        public string message = "";
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\documents\\visual studio 2017\\Projects\\Discuss-Music\\Discuss-Music\\App_Data\\CoolestDatabaseEver.mdf\";Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                string title = Request.Form["title"];
                string content = Request.Form["content"];
                int writerId = (int)Session["Id"];
                DateTime date = DateTime.Now;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = String.Format("INSERT INTO Articles VALUES ('{0}','{1}','{2}','{3}');", title, content, writerId, date);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}