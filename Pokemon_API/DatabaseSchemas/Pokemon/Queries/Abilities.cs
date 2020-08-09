using System.Collections.Generic;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.DataBaseInterface;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Queries
{
    public class Abilities : ITableQueries<Models.Abilities>, ITableQueriesAll<Models.Abilities>
    {
        private string TableName = "Flags";

        public Abilities() { }

        public async Task<List<Models.Abilities>> GetAll(int number)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }

        public async Task<Models.Abilities> Get(int number)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }

        public async Task<Models.Abilities> Insert(Models.Abilities obj)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Insert into {this.TableName} ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }

        public async Task Delete(int number)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"DELETE * FROM {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
        }
    }
}
