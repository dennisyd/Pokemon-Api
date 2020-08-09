using System;
using System.Threading.Tasks;

using Pokemon_API.DataBaseInterface;

namespace Pokemon_API.DatabaseSchemas.DamageMultiplier
{
    public class Interface
    {
        public const string Schema = "DamageMultipliers";

        public Interface() { }

        public static DatabaseConnector GetDatabaseConnector()
        {
            DatabaseConnector connector = DatabaseConnector.Instance();
            connector.setDatabase(Schema);
            return connector;
        }

        public async Task<Models.Multiplier> GetMultiplier(string name)
        {
            Queries.Multiplier query = new Queries.Multiplier();
            Models.Multiplier result = await query.Get(name);
            return result;
        }

        public async Task<Models.Multiplier> InsertMultiplier(Models.Multiplier obj) {
            Queries.Multiplier query = new Queries.Multiplier();
            Models.Multiplier result = await query.Insert(obj);
            return result;
        }
    }
}
