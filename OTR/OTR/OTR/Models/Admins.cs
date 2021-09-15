using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTR.Models
{
    class Admins
    {
        SqlConnection conn;
        public Admins() { }
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }

        public Admin AuthhencateUser(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Admin WHERE Username='{0}' AND Password= '{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.Username = reader.GetString(reader.GetOrdinal("Username"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return admin;
        }


        public User GetUser(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Users WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = new User();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return user;
        }
        public bool UpdateUser(User user)
        {
            conn.Open();
            string query = String.Format("UPDATE Users SET Name ='{0}' Where Username ='{1}'", user.Name, user.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteUser(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Users WHERE Username ='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Close();
            int r = cmd.ExecuteNonQuery();
            if (r > 0) return true;
            return false;
        }
    }
}
