using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UserRoleValidation
{
    internal class ValidateUserRole 
    {
        String Username;
        String Password;
        public int RoleID;

        public ValidateUserRole(String Username, String Password)
        {
            this.Username = Username;
            this.Password = Password;
            
        }

        public void getUserRole()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);


            conn.Open();
            string userQuery = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(userQuery, conn);

            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);

            object result = cmd.ExecuteScalar();
            int UserID = Convert.ToInt32(result);

            string authQuery = "SELECT RoleID FROM Users WHERE UserID = @UserID";
            SqlCommand cmd2 = new SqlCommand(authQuery, conn);

            cmd2.Parameters.AddWithValue("@UserID", UserID);

            object result2 = cmd2.ExecuteScalar();
            RoleID = Convert.ToInt32(result2);

        
        }
    }
}
