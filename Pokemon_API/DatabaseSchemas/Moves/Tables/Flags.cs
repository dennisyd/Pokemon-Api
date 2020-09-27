using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Moves.Tables
{
    public class Flags : TableQueries<Models.Flags> {

        public override string Database => "Moves";
        public override string TableName => "Flags";

        public Flags() { }

        public override DatabaseConnector GetDatabaseConnector()
        {
            connection.SetDatabase(Database);
            return base.GetDatabaseConnector();
        }

        public async Task<List<Models.Flags>> Get(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"moveNumber", number }
            };

            List<Models.Flags> result = await Get(dict);
            return result;
        }

        public async Task<int?> Insert(Models.Flags obj)
        {
            int? result = await Insert(obj.ToDict());
            return result;
        }

        public async Task<int?> Delete(int number)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"moveNumber", number }
            };

            int? result = await Delete(dict);
            return result;
        }

        public override Models.Flags DataReaderConverter(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            int moveNumber = int.Parse(reader["moveNumber"].ToString());
            string flag = reader["flag"].ToString();

            return new Models.Flags(
                id: id,
                moveNumber: moveNumber,
                flag: flag
            );
        }
    }
}
