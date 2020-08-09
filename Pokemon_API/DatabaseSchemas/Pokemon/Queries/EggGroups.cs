using System.Collections.Generic;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.DataBaseInterface;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Queries
{
    public class EggGroups : ITableQueries<Models.EggGroups>, ITableQueriesAll<Models.EggGroups>
    {
        private string TableName = "EggGroups";

        public EggGroups() { }

        public async Task<List<Models.EggGroups>> GetAll(int number)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }

        public async Task<Models.EggGroups> Get(int number)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }

        public async Task<Models.EggGroups> Insert(Models.EggGroups obj)
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
