using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Tables
{
    public class Moves : TableQueries<Models.Moves>
    {
        public override string Database => "Pokemon";
        public override string TableName => "Moves";

        public Moves() { }

        public override DatabaseConnector GetDatabaseConnector()
        {
            connection.SetDatabase(Database);
            return base.GetDatabaseConnector();
        }

        public async Task<List<Models.Moves>> Get(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"pokemonNumber", number }
            };

            List<Models.Moves> result = await Get(dict);
            return result;
        }

        public async Task<int?> Insert(Models.Moves obj)
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

        public override Models.Moves DataReaderConverter(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            int pokemonNumber = int.Parse(reader["pokemonNumber"].ToString());
            int moveNumber = int.Parse(reader["moveNumber"].ToString());
            int level = int.Parse(reader["level"].ToString());
            bool isTm = bool.Parse(reader["isTM"].ToString());
            bool isHm = bool.Parse(reader["isHM"].ToString());



            return new Models.Moves(
                Id: id,
                PokemonNumber: pokemonNumber,
                MoveNumber: moveNumber,
                Level: level,
                IsTM: isTm,
                IsHM: isHm
            );
        }
    }
}
