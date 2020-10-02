using System;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Pokemon_API.Extensions
{
    public class DatabaseConnector
    {
        protected string id;
        protected static string Password = "pE#31$5u1P0425";
        protected static string Username = "admin";
        protected static int Port = 3306;
        protected static string Endpoint = "pokemon-db.c9h4e2habiis.us-east-2.rds.amazonaws.com";
        protected static string Database = "base";

        protected static string ConnectionString = $"Server={Endpoint}; database={Database}; UID={Username}; password={Password}";

        protected MySqlConnection connection;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DatabaseConnector _instance = null;
        public static DatabaseConnector Instance()
        {
            if (_instance == null)
                _instance = new DatabaseConnector();
            return _instance;
        }

        public DatabaseConnector()
        {
            id = new Random().Next(0, 100).ToString();
        }

        public void SetDatabase(string database) {
            Database = (!string.IsNullOrEmpty(database)) ? database : DatabaseConnector.Database;
        }

        public async Task<bool> IsConnected()
        {
            string connection_string = $"Server={Endpoint}; database={Database}; UID={Username}; password={Password}";
            connection = new MySqlConnection(connection_string);
            await connection.OpenAsync();
            return connection.State == System.Data.ConnectionState.Open;
        }

        public async Task Disconnect()
        {
            await connection.CloseAsync();
        }
    }
}
