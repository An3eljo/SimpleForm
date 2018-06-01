using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql;
using MySql.Data.MySqlClient;

namespace SimpleForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OnSubmitClick(this, EventArgs.Empty);
        }

        private void OnSubmitClick(object sender, EventArgs e)
        {
            var username = "testuser";
            var password = "testpass";
            var connection = new MySqlConnection(
                "Server=localhost; Port=3306; Database=dbschool; Uid=root; Pwd=;SSLMode=None");
            connection.Open();

            MySqlDataReader dataReader =
                new MySqlCommand($"Select * from user where Username='{username}' and Password='{password}';", connection).ExecuteReader();

            var newUser = new User();
            while (dataReader.Read())
            {
                if (username == dataReader["Username"] as string && password == dataReader["Password"] as string)
                {
                    newUser.Username = username;
                    newUser.Password = password;
                    newUser.Id = (int)dataReader["Id"];
                    newUser.Email = dataReader["Email"] as string;
                }
            }
            Session.Add("CurrentUser", newUser);
            Response.Redirect("About.aspx");
        }
    }
}