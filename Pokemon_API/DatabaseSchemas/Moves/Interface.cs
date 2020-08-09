using System.Collections.Generic;
using System.Threading.Tasks;

using Pokemon_API.DataBaseInterface;

namespace Pokemon_API.DatabaseSchemas.Moves
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

        public async Task<List<Models.Flags>> GetFlags(int number)
        {
            Queries.Flags query = new Queries.Flags();
            List<Models.Flags> result = await query.Get(number);
            return result;
        }

        public async Task<Models.Flags> InsertFlag(Models.Flags obj)
        {
            Queries.Flags query = new Queries.Flags();
            Models.Flags result = await query.Insert(obj);
            return result;

        }

        public async Task<Models.Moves> GetMove(int number = default(int), string name = default(string))
        {
            Queries.Move query = new Queries.Move();
            Models.Moves result = null;

            if(number == default(int) && string.IsNullOrEmpty(name))
            {
                throw new System.Exception("Missing parameters");
            }

            if (number != default(int))
            {
                result = await query.Get(number);
            }

            if (!string.IsNullOrEmpty(name))
            {
                result = await query.Get(name);
            }
            return result;
        }

        public async Task<Models.Moves> InsertMove(Models.Moves obj)
        {
            Queries.Move query = new Queries.Move();
            Models.Moves result = await query.Insert(obj);
            return result;
        }
    }
}
