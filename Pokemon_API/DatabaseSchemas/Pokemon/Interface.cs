using System.Collections.Generic;
using System.Threading.Tasks;

using Pokemon_API.DataBaseInterface;

namespace Pokemon_API.DatabaseSchemas.Pokemon
{
    public class Interface
    {
        public const string Schema = "Pokemon";

        public Interface() { }

        public static DatabaseConnector GetDatabaseConnector()
        {
            DatabaseConnector connector = DatabaseConnector.Instance();
            connector.setDatabase(Schema);
            return connector;
        }
    }
}
