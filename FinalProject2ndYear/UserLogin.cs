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
    public class UserAuthentication
    {
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockTrackDB;Integrated Security=True";
        String Username;
        String Password;
        public Boolean isAuth;
        public UserAuthentication(String Username, String Password)
        {
            this.Username = Username;
            this.Password = Password;

        }
        public void LoginMethod()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();

                String queryLogin = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password AND Status = 1";
                SqlCommand cmd = new SqlCommand(queryLogin, conn);

                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);

                int result = (int)cmd.ExecuteScalar();

                if (result == 0)
                {
                    MessageBox.Show("Login failed. Try again.", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (result >= 1)
                {
                    MessageBox.Show("Login successful", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainDashboard main = new MainDashboard(Username, Password);
                    main.Show();
                    isAuth = true;


                }
            }
        }
    }
}