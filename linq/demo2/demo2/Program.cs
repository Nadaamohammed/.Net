using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
namespace demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Load connection string from appsettings.json
            var connectionString = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetSection("con1").Value;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert into Users (id ,name ) values (@id,@name)", conn);
            SqlParameter p1 = new SqlParameter("@id", Value=1);
            cmd.Parameters.Add(p1);
            conn.Open();
            int x = cmd.ExecuteNonQuery();//update insert delete
            conn.Close();

        }
        static void ExecuteReader(string[] args)
        {
            var connectionString = new ConfiurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetSection("con1").value;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlCommand sqlCommand = new SqlCommand("SELECT * FROM Users", sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}");
            }
            sqlConnection.Close();
        }
    }
}
