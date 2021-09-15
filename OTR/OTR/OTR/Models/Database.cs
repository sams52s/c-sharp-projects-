using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTR.Models
{
    class Database
    {
        public Admins Admins { get; set; }
        public Users Users { get; set; }
        public Products Products { get; set; }

        
        public Database()
        {
            string connString = "Server=DESKTOP-KGLG4FI;Integrated Security=true;Database=OTR";
            SqlConnection conn = new SqlConnection(connString);

            Admins = new Admins(conn);
            Users = new Users(conn);
            Products = new Products(conn);
            

        }
        public static SqlConnection ConnectBD()
        {
            string connString = "Server=DESKTOP-KGLG4FI;Integrated Security=true;Database=OTR";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
