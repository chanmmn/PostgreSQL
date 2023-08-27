using Npgsql;

namespace ConAppPostGreSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Start!");
            
        }

        public static void ReadPostGreSQL()
        {
            string cs = "Host=localhost;Username=postgres;Password=Password;Database=test";

            using NpgsqlConnection con = new NpgsqlConnection(cs);
            con.Open();

            string sql = "SELECT * From Person";

            using NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

            //var version = cmd.ExecuteScalar().ToString();
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString());
            }
            //Console.WriteLine($"PostgreSQL version: {version}");
        }
    }
}