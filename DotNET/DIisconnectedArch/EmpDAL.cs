using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Discconected
{
    public class EmpDAL
    {
        private string _connectionString;
        SqlDataAdapter dataAdapter;
        DataSet dataset;
        SqlConnection connection;
        public EmpDAL(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
            connection = new SqlConnection(_connectionString);
        }

        public DataTable GetList()
        {
            // Create an instance of SqlDataAdapter. Spcify the command and the connection

            dataAdapter = new SqlDataAdapter("select * from EmployeeDB", connection);
            // Create an instance of DataSet, which is an in-memory datastore for storing tables
            dataset = new DataSet();
            // Call the Fill() methods, which automatically opens the connection, executes the command 
            // and fills the dataset with data, and finally closes the connection.   //no open method
            dataAdapter.FillSchema(dataset, SchemaType.Source, "EmployeeDB");
            dataAdapter.Fill(dataset, "EmployeeDB");
            Console.WriteLine(dataset.GetXml());
            dataset.Tables[0].TableName = "EmployeeDB";
            DataTable dt = dataset.Tables["EmployeeDB"];

            return dt;
        }
        public void addindataset()
        {
            DataRow drCurrent = dataset.Tables["EmployeeDB"].NewRow();
            //drCurrent["Id"] = 7;
            drCurrent["Name"] = "Vidya";
            drCurrent["Salary"] = 90000;

            dataset.Tables["EmployeeDB"].Rows.Add(drCurrent);
            Console.WriteLine("Add was successful, Click any key to continue!!");
          
            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
            Console.WriteLine(co.GetInsertCommand().CommandText);
            dataAdapter.Update(dataset, "EmployeeDB");
        }
        public void deletebyid(int id)
        {
            DataRow dd = dataset.Tables["EMployeeDB"].Rows.Find(id);

            dd.Delete();

            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);

            dataAdapter.Update(dataset, "EmployeeDB");
            Console.WriteLine(co.GetDeleteCommand().CommandText);
        }
        public void updatedata(int id)
        {
            DataRow dd = dataset.Tables["EmployeeDB"].Rows.Find(id);

            dd["Name"] = "Rajjjaaaa";

            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataset, "EmployeeDB");
            Console.WriteLine(co.GetUpdateCommand().CommandText);
        }
    }
}
