using System;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Pokemon_API.DatabaseSchemas.Moves.Queries
{
    public class Move
    {
        private string TableName = "Move";

        public Move() { }

        public async Task<Models.Moves> Get(string name)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }


        public async Task<Models.Moves> Get(int number)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }

        public async Task<Models.Moves> Insert(Models.Moves obj)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Insert into {this.TableName} ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }
    }
}
