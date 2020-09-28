using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Tables
{
    public class Evolutions : TableQueries<Models.Evolutions>
    {
        public override string Database => "Pokemon";
        public override string TableName => "Evolutions";

        public Evolutions() { }

        public override DatabaseConnector GetDatabaseConnector()
        {
            connection.SetDatabase(Database);
            return base.GetDatabaseConnector();
        }

        public async Task<List<Models.Evolutions>> Get(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"pokemonNumber", number }
            };

            List<Models.Evolutions> result = await Get(dict);
            return result;
        }

        public async Task<int?> Insert(Models.Evolutions obj)
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

        public override Models.Evolutions DataReaderConverter(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            int pokemonNumber = int.Parse(reader["pokemonNumber"].ToString());
            string evolution = reader["evolution"].ToString();

            return new Models.Evolutions(
                id: id,
                pokemonNumber: pokemonNumber,
                evolution: evolution
            );
        }
    }
}
