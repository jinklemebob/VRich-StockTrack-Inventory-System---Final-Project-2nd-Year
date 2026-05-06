using FinalProject2ndYear;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFunction
{
    public class UserLogin 
    {
        String Username;
        String Password;
        public UserLogin(String Username, String Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public void LoginMethod()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            String queryLogin = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(queryLogin, conn);

            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            
            int result = (int)cmd.ExecuteScalar();

            if (result == 0)
            {
                MessageBox.Show("Incorrect login.");

            }
            else if (result >= 1)
            {
                MessageBox.Show("Login Successful");
                MainDashboard main = new MainDashboard(Username, Password);
                main.Show();
            }
        }
    }
}
