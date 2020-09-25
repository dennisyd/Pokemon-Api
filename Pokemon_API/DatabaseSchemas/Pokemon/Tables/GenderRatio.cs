using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Tables
{
    public class GenderRatio : TableQueries<Models.GenderRatio>
    {
        public override string Database => "Pokemon";
        public override string TableName => "GenderRatio";

        public GenderRatio() { }

        public override DatabaseConnector GetDatabaseConnector()
        {
            connection.SetDatabase(Database);
            return base.GetDatabaseConnector();
        }

        public async Task<Models.GenderRatio> Get(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"pokemonNumber", number }
            };

            List<Models.GenderRatio> result = await Get(dict);
            return result.FirstOrDefault();
        }

        public async Task<int?> Insert(Models.GenderRatio obj)
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

        public override Models.GenderRatio DataReaderConverter(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            int pokemonNumber = int.Parse(reader["pokemonNumber"].ToString());
            float male = float.Parse(reader["male"].ToString());
            float female = float.Parse(reader["female"].ToString());

            return new Models.GenderRatio(
                Id: id,
                PokemonNumber: pokemonNumber,
                Male: male,
                Female: female
            );
        }
    }
}
