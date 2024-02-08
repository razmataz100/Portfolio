using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämningsuppgift1Databasteknik.Repository;

namespace Inlämningsuppgift1Databasteknik.Classes
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int userID, string username, string password)
        {
            UserID = userID;
            Username = username;
            Password = password;
        }

        public static void SaveNewUser(User user)
        {
            UserRepo.Save(user);
        }
    }
}
