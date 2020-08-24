using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.DamageMultiplier.Queries
{
    internal class Multiplier : TableQueries<Models.Multiplier>
    {
        private new string Database = "Multipliers";
        private new string TableName = "Multipliers";

        public Multiplier() { }

        public override async Task<List<Models.Multiplier>> Get(Dictionary<string, object> values)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }

        public async Task<Models.Multiplier> Get(string name)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }

        public async Task<Models.Multiplier> Insert(Models.Multiplier obj)
        {
            var connection = Interface.GetDatabaseConnector();
            if (await connection.IsConnected())
            {
                string query = $"Insert * INTO {this.TableName} ...";
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
