using Pokemon_API.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_API.DatabaseSchemas.Pokemon
{
    public static class PokemonDB
    {
        private static string Database => "Pokemon";

        private static DatabaseConnector connector = null;
        public static async Task<DatabaseConnector> getDBConnection()
        {
            if(PokemonDB.connector != null)
            {
                return PokemonDB.connector;
            }

            DatabaseConnector connector = new DatabaseConnector();
            connector.SetDatabase(Database);
            await connector.IsConnected();
            PokemonDB.connector = connector;
            return connector;
        }
    }
}
