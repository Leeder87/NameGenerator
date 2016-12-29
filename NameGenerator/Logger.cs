using MySql.Data.MySqlClient;

namespace NameGenerator
{
    public class Logger
    {
        public static void LogName(GeneratedName name)
        {
            MySQLConn connection = new MySQLConn();
            connection.OpenConnection();
            try
            {
                string command = "insert into log (`eng_name`, `rus_name`, `date_of_birth`,	`comment`) values ('" + name.EngName + "', '" + name.RusName
                    + "', '" + name.DateOfBirth + "', '" + name.Comment + "')";
                MySqlCommand sqlCom = new MySqlCommand(command, MySQLConn.conn);
                sqlCom.ExecuteNonQuery();
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}