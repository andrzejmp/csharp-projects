//--------------------------------------------------
//Connect to SQL Server using Windows Authentication
//--------------------------------------------------

using System;
using System.Data.SqlClient;

namespace sqlserver
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.\\SQLEXPRESS;Database=NBA;Trusted_Connection=Yes";
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = "select * from gracz;";
            try
            {
                conn.Open();
                SqlDataReader rdr = null;
            
                SqlCommand cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr["idGracza"].ToString() + " " + rdr["nazwisko"].ToString() + " " + rdr["imie"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Close();
            //Console.ReadKey();
        }
    }
}
