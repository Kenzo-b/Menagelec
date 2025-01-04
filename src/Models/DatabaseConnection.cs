using MySql.Data.MySqlClient;

namespace Menagelec.src.Models
{
    abstract class DatabaseConnection
    {
        private const string SERVER = "localhost";
        private const string PORT = "3306";
        private const string DATABASE = "menageleccsharp";
        private const string UID = "root";
        private const string PASSWORD = "";


        public static MySqlConnection connect()
        {
            string connectInfo = $"server={SERVER};" +
                                 $"port={PORT};" +
                                 $"database={DATABASE};" +
                                 $"uid={UID};" +
                                 $"password={PASSWORD}";

            MySqlConnection connect = new MySqlConnection(connectInfo);
            connect.Open();
            return connect;
        }
    }
}
