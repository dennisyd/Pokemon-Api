using System;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Pokemon_API.DataBaseInterface
{
    public class DatabaseConnector
    {
        protected string Password = "pE#31$5u1P0425";
        protected string Username = "admin";
        protected int Port = 3306;
        protected string Endpoint = "pokemon-db.c9h4e2habiis.us-east-2.rds.amazonaws.com";
        protected string Database = "base";

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
            string connection_string = $"Server={Endpoint}; database={Database}; UID={Username}; password={Password}";
            connection = new MySqlConnection(connection_string);
        }

        public void setDatabase(string database) {
            this.Database = (!string.IsNullOrEmpty(database)) ? database : this.Database;
        }


        public async Task<bool> IsConnected()
        {
            string connection_string = $"Server={Endpoint}; database={Database}; UID={Username}; password={Password}";
            connection = new MySqlConnection(connection_string);
            await connection.OpenAsync();
            return connection.State == System.Data.ConnectionState.Open;
        }

        public async void Disconnect()
        {
            await connection.CloseAsync();
        }
    }
}
