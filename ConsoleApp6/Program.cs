using MySql.Data.MySqlClient;

namespace ConsoleApp6
{
    internal class Program
    {
        public static string connectionString = $"{server};{database};{uid};{pwd}";
        private static string server = "Server=sql.freedb.tech";
        private static string database = "Database=freedb_PlanMe_DB";
        private static string uid = "Uid=freedb_PlanMe";
        private static string pwd = "Pwd=etkN3V6sZ3Pv&CU";

        static void Main(string[] args)
        {
            MySqlConnection conn = 
                new("Server=sql.freedb.tech;Database=freedb_PlanMe_DB;Uid=freedb_PlanMe;Pwd=etkN3V6sZ3Pv&CU");
            string phrase = "";
            Random random = new Random();
            int randomNum = random.Next(0, 390);
            conn.Open();
            using (conn)
            {
                string query = "SELECT phrase FROM daily_phrase WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", randomNum);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                
                    phrase = reader["phrase"].ToString();
                
            }
            Console.WriteLine(phrase);
        }
    }
}