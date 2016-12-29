using MySql.Data.MySqlClient;

namespace NameGenerator
{
    public class MySQLConn
    {
        public static MySqlConnection conn = null;

        public void OpenConnection()
        {
            // Боевые данные
            string serverName = "148.251.9.187"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "name_reader"; // Имя пользователя
            string dbName = "name_generator"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = "quci4HNBYWZYbeM"; // Пароль для подключения
           /*
            // Тестовые данные
            string serverName = "127.0.0.1"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "root"; // Имя пользователя
            string dbName = "name_generator"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = "12345"; // Пароль для подключения
            */
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";Charset = utf8" +
                ";port=" + port +
                ";password=" + password + ";";
            // Should remove the connection string into a config file
            conn = new MySqlConnection(connStr);

            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }
    }
}