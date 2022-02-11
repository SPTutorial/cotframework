using COT.DAL;
using MySql.Data.MySqlClient;
using System;

namespace TestDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MySQLHelper sqlHelper = new MySQLHelper("Server=localhost;Database=dbcotframework;Uid=admin;Pwd=admin@123;");

            //var ds = sqlHelper.ExecuteDataset(System.Data.CommandType.Text, "select * from tbldobmaster", null);

            MySqlParameter[] sqlpr = new MySqlParameter[2];
            sqlpr[0] = new MySqlParameter("pin", 5);
            sqlpr[1] = new MySqlParameter("dob", "1665-10-09");

            int i = sqlHelper.ExecuteNonQuery(System.Data.CommandType.StoredProcedure, "sp_InsertData", sqlpr);
        }
    }
}
