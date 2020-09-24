using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Moves.Tables
{
    public class Move : TableQueries<Models.Moves>
    {
        public override string Database => "Moves";
        public override string TableName => "Move";

        public Move() { }

        public override DatabaseConnector GetDatabaseConnector()
        {
            connection.SetDatabase(Database);
            return base.GetDatabaseConnector();
        }

        public async Task<Models.Moves> Get(string name)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"name", name }
            };

            List<Models.Moves> result = await Get(dict);
            return result.FirstOrDefault();
        }

        public async Task<Models.Moves> Get(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"number", number }
            };

            List<Models.Moves> result = await Get(dict);
            return result.FirstOrDefault();
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

        public override Models.Moves DataReaderConverter(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            string name = reader["name"].ToString();
            int number = int.Parse(reader["number"].ToString());
            int accuracy = int.Parse(reader["accuracy"].ToString());
            int basePower = int.Parse(reader["basePower"].ToString());
            string category = reader["category"].ToString();
            string description = reader["description"].ToString();
            string shortDescription = reader["shortDescription"].ToString();
            int pp = int.Parse(reader["pp"].ToString());
            int priority = int.Parse(reader["priority"].ToString());
            int criticalRatio = int.Parse(reader["critRatio"].ToString());
            string target = reader["target"].ToString();
            string type = reader["type"].ToString();
            string contestType = reader["contestType"].ToString();

            return new Models.Moves(
                Id: id,
                Name: name,
                Number: number,
                Accuracy: accuracy,
                BasePower: basePower,
                Category: category,
                Description: description,
                ShortDescription: shortDescription,
                PP: pp,
                Priority: priority,
                CritRatio: criticalRatio,
                Target: target,
                Type: type,
                ContestType: contestType
            );
        }
    }
}
