using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Tables
{
    public class EggGroups : TableQueries<Models.EggGroups>
    {
        public override string Database => "Pokemon";
        public override string TableName => "EggGroup";

        public EggGroups() { }
        public async override Task<DatabaseConnector> GetDatabaseConnector()
        {
            return await PokemonDB.getDBConnection();
        }

        public async Task<Models.EggGroups> Get(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"pokemonNumber", number }
            };

            List<Models.EggGroups> result = await Get(dict);
            return result.FirstOrDefault();
        }

        public async Task<int?> Insert(Models.EggGroups obj)
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

        public override Models.EggGroups DataReaderConverter(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            int pokemonNumber = int.Parse(reader["pokemonNumber"].ToString());
            string eggGroup1 = reader["eggGroup1"].ToString();
            string eggGroup2 = (!string.IsNullOrEmpty(reader["eggGroup2"].ToString())) ? reader["eggGroup2"].ToString() : null;

            return new Models.EggGroups(
                id: id,
                pokemonNumber: pokemonNumber,
                eggGroup1: eggGroup1,
                eggGroup2: eggGroup2
            );
        }

    }
}
