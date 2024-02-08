using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlämningsuppgift1Databasteknik.Classes;

namespace Inlämningsuppgift1Databasteknik.Repository
{
    public class UserRepo
    {
        public static int Save(User user)
        {
            string sql = "insert into Users (Username, Password) values (@Username, @Password) SELECT SCOPE_IDENTITY()";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Username", user.Username));
            parameters.Add(new SqlParameter("@Password", user.Password));

            DataTable data = Datahandler.ExecuteReturnTable(sql, parameters);

            int generatedUserID = Convert.ToInt32(data.Rows[0][0]);
            user.UserID = generatedUserID;
            return generatedUserID;

        }

        public static bool IsUsernameUnique(string username)
        {
            string sql = "SELECT TOP 1 Username FROM Users WHERE Username = @Username";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Username", username),
            };

            DataTable data = Datahandler.ExecuteReturnTable(sql, parameters);
            return data.Rows.Count == 0;
        }

        public static User AuthenticateUser(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
            };

            DataTable data = Datahandler.ExecuteReturnTable(sql, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new User((int)row["UserID"], row["Username"].ToString(), row["Password"].ToString());
            }

            return null;
        }

        public static string GetUsernameByUserID(int userID)
        {
            string sql = "select username from users where UserID = userID";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", userID)
            };

            DataTable data = Datahandler.ExecuteReturnTable(sql, new List<SqlParameter>());

            if(data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return row["Username"].ToString();
            }
            return null;

        }
    }
}
