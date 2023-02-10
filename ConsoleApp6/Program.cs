using MySql.Data.MySqlClient;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = 
                new("Server=sql.freedb.tech;Database=freedb_PlanMe_DB;Uid=freedb_PlanMe;Pwd=etkN3V6sZ3Pv&CU");
            conn.Open();
            using (conn)
            {
                MySqlCommand cmd = new(
                    "INSERT INTO users(username, password)" +
                    "VALUES (\"Пешо1\", 123456);"
                    , conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}