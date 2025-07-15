using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=.;Database=testado;integratedsecurity=true");
            SqlCommand sqlCommand = new SqlConnection("select * from department",sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;
            
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
            }
            sqlConnection.Close();
        }
    }
}
