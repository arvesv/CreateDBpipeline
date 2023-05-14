using System.Data;
using Microsoft.Data.SqlClient;

namespace CoreLib
{
    public class MyTools
    {
        public static int Answer() => 42;


        public static IEnumerable<string> DbWho(string connectionString)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            var dbCommand = connection.CreateCommand();
            dbCommand.CommandText = "sp_databases;";
            var reader = dbCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
                yield return reader.GetString("database_name");
        }
    }

}
