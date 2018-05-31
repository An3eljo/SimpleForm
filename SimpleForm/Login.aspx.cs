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

        }

        private void OnSubmitClick(object sender, EventArgs e)
        {
            var username = ;
            var password = ;
            var connection = new MySqlConnection(
                "Server=tcp:andrischool.database.windows.net,1433;" +
                "Initial Catalog=M133_Test;Persist Security Info=False;" +
                "User ID={your_username};Password={your_password};" +
                "MultipleActiveResultSets=False;Encrypt=True;" +
                "TrustServerCertificate=False;Connection Timeout=30;");
            connection.Open();

            MySqlDataReader dataReader =
                new MySqlCommand($"Select * from Users where name='{}' and password='{}'", connection).ExecuteReader();

            var newUser = new User();
            while (dataReader.Read())
            {
                if (username == dataReader["Username"] as string && password == dataReader["Password"] as string)
                {
                    newUser.Username = username;
                    newUser.Password = password;
                    newUser.Id = (int) dataReader["Id"];
                    newUser.Email = dataReader["Email"] as string;
                }
            }
            Session.Add("CurrentUser", newUser);
        }
    }
}