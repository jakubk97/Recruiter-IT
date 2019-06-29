using MySql.Data.MySqlClient;

namespace Recruiter
{
    class DBConnection
    {
        private static DBConnection instance = null;
        public static DBConnection Instance
        {
            get
            {
                return instance ?? (instance = new DBConnection());
            }
        }

        public MySqlConnection Connection { get; private set; }

        private DBConnection()
        {
            MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder
            {
                UserID = DBInfo.user,
                Password = DBInfo.password,
                Database = DBInfo.database,
                Port = uint.Parse(DBInfo.port),
                Server = DBInfo.server
            };

            Connection = new MySqlConnection(connectionStringBuilder.ToString());
        }
    }
}
