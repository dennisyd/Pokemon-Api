using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Tables
{
    public class BaseStats : TableQueries<Models.BaseStats>
    {
        public override string Database => "Pokemon";
        public override string TableName => "BaseStats";

        public BaseStats() { }

        public override DatabaseConnector GetDatabaseConnector()
        {
            connection.SetDatabase(Database);
            return base.GetDatabaseConnector();
        }

        public async Task<Models.BaseStats> Get(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"pokemonNumber", number }
            };

            List<Models.BaseStats> result = await Get(dict);
            return result.FirstOrDefault();
        }

        public async Task<int?> Insert(Models.BaseStats obj)
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

        public override Models.BaseStats DataReaderConverter(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            int pokemonNumber = int.Parse(reader["pokemonNumber"].ToString());
            int hp = int.Parse(reader["hp"].ToString());
            int attack = int.Parse(reader["attack"].ToString());
            int defense = int.Parse(reader["defense"].ToString());
            int specialAttack = int.Parse(reader["specialAttack"].ToString());
            int specialDefense = int.Parse(reader["specialDefense"].ToString());
            int speed = int.Parse(reader["speed"].ToString());

            return new Models.BaseStats(
                id: id,
                pokemonNumber: pokemonNumber,
                hp: hp,
                attack: attack,
                defense: defense,
                specialAttack: specialAttack,
                specialDefense: specialDefense,
                Speed: speed
            );
        }
    }
}
