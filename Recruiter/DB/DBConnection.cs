using MySql.Data.MySqlClient;

namespace Recruiter
{
    public sealed class DBConnection
    {
        private static DBConnection instance = null;
        public MySqlConnection Connection { get; private set; }
        public static DBConnection Instance
        {
            get
            {
                return instance ?? (instance = new DBConnection());
            }
        }

        private DBConnection()
        {
            try
            {
                MySqlConnectionStringBuilder connectionStringBuilder = new MySqlConnectionStringBuilder
                {
                    UserID = DB.DBInformations.user,
                    Password = DB.DBInformations.password,
                    Database = DB.DBInformations.database,
                    Port = uint.Parse(DB.DBInformations.port),
                    Server = DB.DBInformations.server
                };

                Connection = new MySqlConnection(connectionStringBuilder.ToString());
            }
            catch (System.Exception ex)
            {
            }
        }
    }
}
