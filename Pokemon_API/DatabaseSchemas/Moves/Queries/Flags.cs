using System.Collections.Generic;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Pokemon_API.DatabaseSchemas.Moves.Queries
{
    public class Flags
    {
        private string TableName = "Flags";

        public Flags() { }

        public async Task<List<Models.Flags>> Get(int number)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }

        public async Task<Models.Flags> Insert(Models.Flags obj)
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
