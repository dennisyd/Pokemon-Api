using System;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Pokemon_API.DatabaseSchemas.DamageMultiplier.Queries
{
    internal class Multiplier
    {
        private string TableName = "Multipliers";

        public Multiplier() { }

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
                string query = $"Insert into {this.TableName} ...";
                MySqlCommand command = new MySqlCommand(query);
            }
            return null;
        }
    }
}
