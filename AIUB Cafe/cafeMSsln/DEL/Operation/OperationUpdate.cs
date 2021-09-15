using DEL.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEL.Operation
{
    public class OperationUpdate
    {
        public bool update(EntityUsers entityUsers)
        {
            
                SqlConnection sqlConnection = new SqlConnection("Data Source=ta52;Initial Catalog=MS;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO user " + "(name,password,email,phone,gender,usertype)" + " values('" + entityUsers.name + "','" + entityUsers.password + "','" + entityUsers.email + "','" + entityUsers.phone + "','" + entityUsers.gender + "','" + entityUsers.usertype + "')", sqlConnection);
                int row = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (row > 0) { return true; }
                else { return false; }
            
        }
    }
}
