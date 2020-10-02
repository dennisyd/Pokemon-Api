using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Tables
{
    public class Abilities : TableQueries<Models.Abilities>
    {
        public override string Database => "Pokemon";
        public override string TableName => "Abilities";

        public Abilities() { }

        public override DatabaseConnector GetDatabaseConnector()
        {
            connection.SetDatabase(Database);
            return base.GetDatabaseConnector();
        }

        public async Task<Models.Abilities> Get(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"pokemonNumber", number }
            };

            List<Models.Abilities> result = await Get(dict);
            return result.FirstOrDefault();
        }

        public async Task<int?> Insert(Models.Abilities obj)
        {
            int? result = await Insert(obj.ToDict());
            return result;
        }

        public async Task<int?> Delete(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"pokemonNumber", number }
            };

            int? result = await Delete(dict);
            return result;
        }

        public override Models.Abilities DataReaderConverter(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            int pokemonNumber = int.Parse(reader["pokemonNumber"].ToString());
            string ability1 = reader["ability1"].ToString();
            string ability2 = (!string.IsNullOrEmpty(reader["ability2"].ToString())) ? reader["ability2"].ToString() : null;
            string ability3 = (!string.IsNullOrEmpty(reader["ability3"].ToString())) ? reader["ability3"].ToString() : null;
            string ability4 = (!string.IsNullOrEmpty(reader["ability4"].ToString())) ? reader["ability4"].ToString() : null;

            return new Models.Abilities(
                id: id,
                pokemonNumber: pokemonNumber,
                ability1: ability1,
                ability2: ability2,
                ability3: ability3,
                ability4: ability4
            );
        }
    }
}
