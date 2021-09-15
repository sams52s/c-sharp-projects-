using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicl_layer
{
    public class ItemsController
    {
        string er, ot;
        SqlCommand com;
        
        SqlConnection con = new SqlConnection("Data Source=ta52;Initial Catalog=MYDB;Integrated Security=True");
        public string create(string Name, int quantity, int Price)
        {
            con.Close();
            con.Open();
            try
            {
                com = new SqlCommand("INSERT INTO Item (Name,quantity,price) values (@Name,@quantity,@price)", con);
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@quantity", quantity);
                com.Parameters.AddWithValue("@price", Price);
                com.ExecuteNonQuery();
                return "Info Added";
            }

            catch (Exception ex)
            {
                er = (ex.Message);
                return er;
            }
            con.Close();
        }
        public DataTable getAll()
        {
            con.Close();
            SqlDataAdapter da = null;
            DataTable dt2 = new DataTable();
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM Item", con);
            da.Fill(dt2);
            con.Close();
            return dt2;
        }
        public string Remove(int ind)
        {
            
            try
            {

                con.Close();
                con.Open();
                    SqlCommand com = new SqlCommand("DELETE FROM Item WHERE id= '" + ind + "'", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    er = "Delete succesfully";
                    return er;
                
            }
            catch (Exception ex)
            {
                er=ex.Message;
                return er;
            }
        }
        public string updatequantity(int id,int x)
        {
            try
            {
                con.Close();
                con.Open();
                    SqlCommand com = new SqlCommand("UPDATE Item SET quantity= '" + x + "' WHERE id= '" + id + "'", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    er = "Update succesfully";
                    return er;
            }
            catch (Exception ex)
            {
                er = ex.Message;
                return er;
            }
        }
        public string updatePrice(int id, int x)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("UPDATE Item SET Price= '" + x + "' WHERE id= '" + id + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                er = "Update succesfully";
                return er;
            }
            catch (Exception ex)
            {
                er = ex.Message;
                return er;
            }
        }
    }
}
