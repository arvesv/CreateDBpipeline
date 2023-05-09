using Microsoft.Data.SqlClient;

namespace CoreLib
{
    public class MyTools
    {
        public static int Answer() => 42;


        public static string[] DbWho(string connectionString)
        {
            using var connection = new SqlConnection(connectionString);
            using var dbCommand = connection.CreateCommand();
            dbCommand.CommandText = "sp_who;";



            return Array.Empty<string>();


        }
    }

}
