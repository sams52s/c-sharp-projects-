using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRticket
{
    public class Controller
    {
        public string price;
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
                er = ex.Message;
                return er;
            }
        }
        public string updatequantity(int id, int x)
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
        private string uid = "2";
        private string pas;
        public string  ut;
        SqlDataAdapter da;

        public string create(string AIUBId, string Name, string password, string mail, string Phonenumber, string gender, string UserType)
        {
            con.Open();
            try
            {

                com = new SqlCommand("INSERT INTO SignUp (AIUBId,Name,password,mail,Phonenumber,gender,UserType) values (@AIUBId,@Name,@password,@mail,@Phonenumber,@gender,@UserType)", con);
                com.Parameters.AddWithValue("@AIUBId", AIUBId);
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@password", password);
                com.Parameters.AddWithValue("@mail", mail);
                com.Parameters.AddWithValue("@Phonenumber", Phonenumber);
                com.Parameters.AddWithValue("@gender", gender);
                com.Parameters.AddWithValue("@UserType", UserType);
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
        public string get(string id, string password)
        {
            this.uid = id;
            this.pas = password;
            return login();

        }
        public string login()
        {
            con.Open();
            try
            {

                com = new SqlCommand("SELECT * FROM SignUp WHERE Id= '" + uid + "'and Password='" + pas + "'", con);
                da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataReader dr = com.ExecuteReader();
                if (dt.Rows.Count > 0)
                {
                    con.Close();
                    con.Open();
                    SqlCommand com = new SqlCommand("SELECT * FROM SignUp WHERE Id= " + uid, con);
                    dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        try
                        {
                            ut = (dr["UserType"].ToString());

                        }
                        catch (Exception ex)
                        {
                            er = (ex.Message);
                            return er;
                        }

                    }
                    con.Close();
                    return ut;
                }
                else
                {
                    er = "ID not found";
                    return er;
                }
            }
            catch (Exception ex)
            {
                er = (ex.Message);
                return er;
            }
            con.Close();
        }
        public DataTable GetAll()
        {
            SqlDataAdapter da = null;
            DataTable dt1 = new DataTable();
            con.Close();
            con.Open();
            da = new SqlDataAdapter("SELECT Id,AIUBId,name,mail,Phonenumber,gender,UserType FROM SignUp ", con);
            da.Fill(dt1);
            con.Close();
            return dt1;
        }
        public DataTable GetbyId()
        {
            SqlDataAdapter da = null;
            DataTable dt1 = new DataTable();
            con.Close();
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM SignUp WHERE Id= '" + uid + "'", con);
            da.Fill(dt1);
            con.Close();
            return dt1;
        }
        public bool Delete(string id)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("DELETE FROM SignUp WHERE id= '" + int.Parse(id) + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public string updateName(string name)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("UPDATE SignUp SET name= '" + name + "' WHERE id= '" + this.uid + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                er = "update succesfully";
                return er;
            }
            catch (Exception ex)
            {
                er = ex.Message;
                return er;
            }
        }
        public string updatepassword(string password)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("UPDATE SignUp SET password= '" + password + "' WHERE id= '" + this.uid + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                er = "update succesfully";
                return er;
            }
            catch (Exception ex)
            {
                er = ex.Message;
                return er;
            }
        }
        public string updatemail(string mail)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("UPDATE SignUp SET mail= '" + mail + "' WHERE id= '" + this.uid + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                er = "update succesfully";
                return er;
            }
            catch (Exception ex)
            {
                er = ex.Message;
                return er;
            }
        }
        public string updatePhonenumber(string Phonenumber)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("UPDATE SignUp SET Phonenumber= '" + Phonenumber + "' WHERE id= '" + this.uid + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                er = "update succesfully";
                return er;
            }
            catch (Exception ex)
            {
                er = ex.Message;
                return er;
            }
        }
        public string get(int itemId, string quantity)
        {
            con.Close();
            con.Open();
            SqlDataAdapter da;
            com = new SqlCommand("SELECT * FROM Item WHERE Id= '" + itemId + "'", con);
            da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = com.ExecuteReader();
            if (dt.Rows.Count > 0)
            {
                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Item WHERE Id= " + itemId, con);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    try
                    {
                        int q = int.Parse((dr["quantity"].ToString()));
                        if (q < int.Parse(quantity))
                        {
                            er = "Out of stock";
                            return er;
                        }
                        else
                        {
                            price = (dr["price"].ToString());
                            int p = int.Parse(price) * int.Parse(quantity);
                            return create(2, itemId, quantity, p.ToString());
                        }

                    }
                    catch (Exception ex)
                    {
                        er = (ex.Message);
                        return er;
                    }

                }
                else
                {
                    er = "Item not found";
                    return er;
                }
            }
            else
            {
                er = "Item not found";
                return er;
            }

        }
        public string create(int userID, int itemId, string quantity, string price)
        {
            con.Close();
            con.Open();
            try
            {

                com = new SqlCommand("INSERT INTO Cart (userID,itemId,quantity,price) values (@userID,@itemId,@quantity,@price)", con);
                com.Parameters.AddWithValue("@userID", userID);
                com.Parameters.AddWithValue("@itemId", itemId);
                com.Parameters.AddWithValue("@quantity", quantity);
                com.Parameters.AddWithValue("@price", price);
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
        public DataTable GetAllCart()
        {
            SqlDataAdapter da = null;
            DataTable dt1 = new DataTable();
            con.Close();
            con.Open();
            da = new SqlDataAdapter("SELECT * FROM Cart ", con);
            da.Fill(dt1);
            con.Close();
            return dt1;
        }
        public DataTable GetAllOrder()
        {
            SqlDataAdapter dao = null;
            DataTable dt1 = new DataTable();
            con.Close();
            con.Open();
            dao = new SqlDataAdapter("SELECT * FROM Order ", con);
            dao.Fill(dt1);
            con.Close();
            return dt1;
        }
        public string RemoveAll()
        {

            try
            {

                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Cart ", con);
                com.ExecuteNonQuery();
                con.Close();
                er = "Delete succesfully";
                return er;

            }
            catch (Exception ex)
            {
                er = ex.Message;
                return er;
            }
        }
        public string Removecart(int ind)
        {

            try
            {

                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("DELETE FROM Cart WHERE id= '" + ind + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                er = "Delete succesfully";
                return er;

            }
            catch (Exception ex)
            {
                er = ex.Message;
                return er;
            }
        }
        public string updatecartquantity(int id, int x)
        {
            try
            {

                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("UPDATE Cart SET quantity= '" + x + "' WHERE id= '" + id + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                er = "update succesfully";
                return er;
            }
            catch (Exception ex)
            {
                er = ex.Message;
                return er;
            }
        }
        public string confirmorder()
        {
            con.Close();
            con.Open();
            SqlDataAdapter da;
            com = new SqlCommand("SELECT * FROM Cart ", con);
            da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = com.ExecuteReader();
            if (dt.Rows.Count > 0)
            {
                con.Close();
                con.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Cart ", con);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    try
                    {
                        int itemId = int.Parse((dr["itemId"].ToString()));
                        string price = (dr["quantity"].ToString());
                        int userId = int.Parse((dr["userId"].ToString()));
                        return order(userId, itemId, price);

                    }
                    catch (Exception ex)
                    {
                        er = (ex.Message);
                        return er;
                    }

                }
                else
                {
                    er = "Item not found";
                    return er;
                }
            }
            else
            {
                er = "Item not found";
                return er;
            }
        }
        public string order(int userId, int itemId, string p)
        {
            con.Close();
            con.Open();
            try
            {

                com = new SqlCommand("INSERT INTO Order (userId,itemId,price) values (@userId,@itemId,@price)", con);
                com.Parameters.AddWithValue("@userId", userId);
                com.Parameters.AddWithValue("@itemId", itemId);
                com.Parameters.AddWithValue("@price", p);
                com.ExecuteNonQuery();
                return "Order confirm";
            }

            catch (Exception ex)
            {
                er = (ex.Message);
                return er;
            }
            con.Close();
        }
    }
}
