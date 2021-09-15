using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FlowerShop
{
    public class userController
    {
        private string uid = "2";
        private string pas;

        public string er, ut;
        SqlCommand com;
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=ta52;Initial Catalog=MYDB;Integrated Security=True");
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
            con.Close();
            SqlDataAdapter da = null;
            DataTable dt1 = new DataTable();
            con.Open();
            da = new SqlDataAdapter("SELECT Id,AIUBId,name,mail,Phonenumber,gender,UserType FROM SignUp ", con);
            da.Fill(dt1);
            con.Close();
            return dt1;
        }
        public DataTable GetbyId()
        {
            con.Close();
            SqlDataAdapter da = null;
            DataTable dt1 = new DataTable();
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

    }
}
