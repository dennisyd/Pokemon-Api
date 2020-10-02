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

        public async override Task<DatabaseConnector> GetDatabaseConnector()
        {
            return await PokemonDB.getDBConnection();
        }

        public async Task<Models.Pokemon> Get(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"number", number }
            };

            List<Models.Pokemon> result = await Get(dict);
            return result.FirstOrDefault();
        }

        public async Task<Models.Pokemon> Get(string name)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"name", name }
            };

            List<Models.Pokemon> result = await Get(dict);
            return result.FirstOrDefault();
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
            string name = reader["name"].ToString();
            int number = int.Parse(reader["number"].ToString());
            float height_m = float.Parse(reader["height_m"].ToString());
            float weight_kg = float.Parse(reader["weight_kg"].ToString());
            string color = reader["color"].ToString();
            string gender = (!string.IsNullOrEmpty(reader["gender"].ToString())) ? reader["gender"].ToString() : null;
            bool? canHatch = null;
            if (!string.IsNullOrEmpty(reader["canHatch"].ToString()))
            {
                bool overrideHatch;
                canHatch = (bool.TryParse(reader["canHatch"].ToString(), out overrideHatch)) ? overrideHatch : canHatch;
            }
            string prevo = (!string.IsNullOrEmpty(reader["prevo"].ToString())) ? reader["prevo"].ToString() : null;

            int? evolutionLevel;
            if (string.IsNullOrEmpty(reader["evoLevel"].ToString()))
            {
                evolutionLevel = null;
            }
            else
            {
                evolutionLevel = int.Parse(reader["evolutionLevel"].ToString());
            }

            string evoType = (!string.IsNullOrEmpty(reader["evoType"].ToString())) ? reader["evoType"].ToString() : null;
            string evoItem = (!string.IsNullOrEmpty(reader["evoItem"].ToString())) ? reader["evoItem"].ToString() : null;
            string evoCondition = (!string.IsNullOrEmpty(reader["evoCondition"].ToString())) ? reader["evoCondition"].ToString() : null;

            return new Models.Pokemon(
                id: id,
                name: name,
                number: number,
                height_m: height_m,
                weight_kg: weight_kg,
                color: color,
                gender: gender,
                canHatch: canHatch,
                prevo: prevo,
                evoLevel: evolutionLevel,
                evoType: evoType,
                evoItem: evoItem,
                evoCondition: evoCondition
            );
        }
    }
}
