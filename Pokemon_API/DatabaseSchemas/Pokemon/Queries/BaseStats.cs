using System;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.DataBaseInterface;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Queries
{
    public class BaseStats : ITableQueries<Models.BaseStats>
    {
        private string TableName = "BaseStats";

        public BaseStats() { }

        public async Task<Models.BaseStats> Get(int number)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }

        public async Task<Models.BaseStats> Insert(Models.BaseStats obj)
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
