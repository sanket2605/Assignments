using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CRUDCustomer
{
    internal class Strongly_type
    {
        private string _connectionString;

        public Strongly_type(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }
        public SqlConnection getconnection()
        {
            SqlConnection sqlconn = new SqlConnection();
            sqlconn.ConnectionString = _connectionString;
            return sqlconn;
        }

        public void UpdateData(int i, string s)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd = null;
            
            try
            {
                sqlconn = getconnection();
                sqlcmd = new SqlCommand("UPDATE Customer set Name=@name where Id=@pid", sqlconn);
                sqlcmd.Parameters.Add("@name", SqlDbType.VarChar).Value= s;
                sqlcmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = i;
                sqlconn.Open();

                Console.WriteLine("Connected");
               int record=sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            { Console.WriteLine(ex); }

            finally
            {
                sqlconn.Close();

            }
           
        }

        public int AddData(Customer e)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            int record = 0;
            try
            {
                sqlconn = getconnection();
                /*sqlcmd = new SqlCommand("storedata", sqlconn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add("@pname", SqlDbType.NVarChar).Value = e.Name;
                sqlcmd.Parameters.Add("@paddress", SqlDbType.NVarChar).Value = e.Address;
                sqlcmd.Parameters.Add("@pmobileno", SqlDbType.NVarChar).Value = e.MobileNo;*/
                sqlcmd=new SqlCommand("INSERT INTO Customer (Name, Address, MobileNo) VALUES (@pname, @paddress, @pmobileno)", sqlconn);
               // sqlcmd.Parameters.AddWithValue("@pid", e.Id);
                sqlcmd.Parameters.AddWithValue("@pname", e.Name);
                sqlcmd.Parameters.AddWithValue("@paddress", e.Address);
                sqlcmd.Parameters.AddWithValue("@pmobileno", e.MobileNo);

                sqlconn.Open();
                Console.WriteLine("Connected");
                record = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception se)
            { Console.WriteLine(se); }
            finally
            {
                sqlconn.Close();
            }
            return record;

        }
        public List<Customer> search(int id)
        {
            SqlConnection sqlconn = getconnection();
            SqlCommand sqlcmd;
            List<Customer> p1 = new List<Customer>();
            try
            {
                //sqlconn = getconnection();
                sqlcmd = new SqlCommand("Select * From Customer where Id=@pid", sqlconn);
                //sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@pid", id);
                sqlconn.Open();
                Console.WriteLine("Connected");
                SqlDataReader rd = sqlcmd.ExecuteReader();
                while (rd.Read())
                {
                    Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Address"], rd["MobileNo"]);

                    /* p1.Add(new Customer
                     {
                         Id = Convert.ToInt32(rd[0]),
                     Name = rd[1].ToString(),
                     Address = rd[2].ToString(),
                     MobileNo = rd[3].ToString()
                     });*/
                }
            }        
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
            }

            return p1;
        }
        public List<Customer> search(string name, string m_num)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            List<Customer> pl = new List<Customer>();
            try
            {

                sqlconn = getconnection();
                sqlcmd = new SqlCommand("select * from Customer where Name=@pname", sqlconn);
                //sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@pname", name);
                sqlcmd = new SqlCommand("select * from Customer where MobileNo=@pmobileno", sqlconn);
                sqlcmd.Parameters.AddWithValue("@pmobileno", m_num);
                sqlconn.Open();
                Console.WriteLine("Connected");
                SqlDataReader rd = sqlcmd.ExecuteReader();
                
                while (rd.Read())
                {
                       // Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Address"], rd["MobileNo"]);

                        Customer p = new Customer();
                        p.Id = Convert.ToInt32(rd[0]);
                        p.Name = rd[1].ToString();
                        p.Address = rd[2].ToString();
                        p.MobileNo = rd[2].ToString(); 
                        pl.Add(p);
                }
                
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();

            }

            return pl;
        }
        public void Del(int id)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            int no = 0;
                try
                {
                    sqlconn = getconnection();
                    sqlconn.Open();
                    sqlcmd = new SqlCommand("delCustomer", sqlconn);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add("@pid", SqlDbType.Int).Value = id;
                    //sqlconn.Open();
                    //Console.WriteLine("connected");
                    no = sqlcmd.ExecuteNonQuery();
                    Console.WriteLine(no);
                }
                catch (SqlException se)
                { Console.WriteLine(se.Message); }
                finally { sqlconn.Close(); }  
        }
        public List<Customer> GetList()
        {
            var listCustomer = new List<Customer>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("displayall", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    Console.WriteLine("Connected");
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3}", rdr["Id"], rdr["Name"], rdr["Address"], rdr["MobileNo"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listCustomer;
        }
    }
}
