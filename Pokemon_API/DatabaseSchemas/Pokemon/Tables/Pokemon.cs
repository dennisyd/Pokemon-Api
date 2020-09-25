using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Tables
{
    public class Pokemon : TableQueries<Models.Pokemon>
    {
        public override string Database => "Pokemon";
        public override string TableName => "Pokemon";

        public Pokemon() { }

        public override DatabaseConnector GetDatabaseConnector()
        {
            connection.SetDatabase(Database);
            return base.GetDatabaseConnector();
        }

        public async Task<List<Models.Pokemon>> Get(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"number", number }
            };

            List<Models.Pokemon> result = await Get(dict);
            return result;
        }

        public async Task<List<Models.Pokemon>> Get(string name)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"name", name }
            };

            List<Models.Pokemon> result = await Get(dict);
            return result;
        }

        public async Task<int?> Insert(Models.Pokemon obj)
        {
            int? result = await Insert(obj.ToDict());
            return result;
        }

        public async Task<int?> Delete(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"number", number }
            };

            int? result = await Delete(dict);
            return result;
        }

        public async Task<int?> Delete(string name)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"name", name }
            };

            int? result = await Delete(dict);
            return result;
        }

        public override Models.Pokemon DataReaderConverter(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            string name = reader["id"].ToString();
            int number = int.Parse(reader["number"].ToString());
            string species = reader["species"].ToString();
            float height = float.Parse(reader["height"].ToString());
            float weight = float.Parse(reader["weight"].ToString());
            string color = reader["color"].ToString();
            int? evolutionLevel = int.Parse(reader["evolutionLevel"].ToString());

            return new Models.Pokemon(
                Id: id,
                Name: name,
                Number: number,
                Species: species,
                Height: height,
                Weight: weight,
                Color: color,
                EvolutionLevel: evolutionLevel
            );
        }
    }
}
