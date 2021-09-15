using OTR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTR.Controller
{
    class AdminController
    {
        static Database db = new Database();
        public static Admin AuthenticateUser(string username, string password)
        {

            return db.Admins.AuthhencateUser(username, password);
        }

        public static User GetUser(string username)
        {
            return db.Users.GetUser(username);
        }
        public static bool UpdateUser(dynamic user)
        {
            User u = new User();
            u.Username = user.Username;
            u.Name = user.Name;
            return db.Users.UpdateUser(u);
        }
        public static bool DeleteUser(string username)
        {
            return db.Users.DeleteUser(username);
        }
    }
}
