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
            Dictionary<string, object> dict = SerializeReader(reader);
            _ = (dict.TryGetValue("id", out object id));
            _ = (dict.TryGetValue("name", out object name));
            _ = (dict.TryGetValue("number", out object number));
            _ = (dict.TryGetValue("height_m", out object height_m));
            _ = (dict.TryGetValue("weight_kg", out object weight_kg));
            _ = (dict.TryGetValue("color", out object color));
            _ = (dict.TryGetValue("gender", out object gender));
            _ = (dict.TryGetValue("prevo", out object prevo));
            _ = (dict.TryGetValue("evoLevel", out object evoLevel));
            _ = (dict.TryGetValue("canHatch", out object canHatch));
            _ = (dict.TryGetValue("evoType", out object evoType));
            _ = (dict.TryGetValue("evoItem", out object evoItem));
            _ = (dict.TryGetValue("evoCondition", out object evoCondition));

            int id_val = int.Parse(id.ToString());
            string name_val = name.ToString();
            int number_val = int.Parse(number.ToString());
            float height_m_val = float.Parse(height_m.ToString());
            float weight_kg_val = float.Parse(weight_kg.ToString());
            string color_val = color.ToString();
            string gender_val = gender.ToString();
            string prevo_val = prevo.ToString();

            bool? canHatch_val = null;
            if (!string.IsNullOrEmpty(canHatch.ToString()))
            {
                canHatch_val = bool.Parse(canHatch.ToString());
            }

            int? evoLevel_val = null;
            if (!string.IsNullOrEmpty(evoLevel.ToString())){
                evoLevel_val = int.Parse(evoLevel.ToString());
            }

            string evoType_val = evoType.ToString();
            string evoItem_val = evoItem.ToString();
            string evoCondition_val = evoCondition.ToString();


            return new Models.Pokemon(
                id: id_val,
                name: name_val,
                number: number_val,
                height_m: height_m_val,
                weight_kg: weight_kg_val,
                color: color_val,
                gender: gender_val,
                canHatch: canHatch_val,
                prevo: prevo_val,
                evoLevel: evoLevel_val,
                evoType: evoType_val,
                evoItem: evoItem_val,
                evoCondition: evoCondition_val
            );
        }
    }
}
