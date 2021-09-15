using OTR.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTR.Controller
{
    class UserController
    {
        static Database db = new Database();
        public static User AuthenticateUser(string username, string password)
        {

            return db.Users.AuthhencateUser(username, password);
        }
        public static bool AddUser(dynamic user)
        {
            User u = new User();
            u.Name = user.Name;
            u.Username = user.Username;
            u.Phone = user.Phone;
            u.Mail = user.Mail;
            u.Gender = user.Gender;
            u.Age = user.Age;
            u.City = user.City;
            u.Password = user.Password;

            return db.Users.AddUser(u);
        }

        public static Product GetProduct(string name)
        {
            return db.Products.GetProduct(name);
        }
        public static ArrayList GetAllProducts()
        {
            return db.Products.GetAllProducts();
        }
    }
}
