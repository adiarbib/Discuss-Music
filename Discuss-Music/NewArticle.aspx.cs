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
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\CoolestDatabaseEver.mdf\";Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                
                if (Session["Id"] != null)
                {
                    string title = Request.Form["title"];
                    string content = Request.Form["content"];
                    DateTime date = DateTime.Now;
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    int writerId = (int)Session["Id"];
                    command.CommandText = String.Format("INSERT INTO Articles VALUES ('{0}','{1}','{2}','{3}');", title, content, writerId, date.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    message = "you should log in before uploading a new post";
                }
                
            }
        }
    }
}