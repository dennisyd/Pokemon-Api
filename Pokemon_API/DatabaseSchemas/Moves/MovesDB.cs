using Pokemon_API.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_API.DatabaseSchemas.Moves
{
    public static class MovesDB
    {
        private static string Database => "Moves";

        private static DatabaseConnector connector = null;
        public static async Task<DatabaseConnector> getDBConnection()
        {
            if (MovesDB.connector != null)
            {
                while(MovesDB.connector.Connection.State == System.Data.ConnectionState.Connecting)
                {
                    await Task.Delay(100);
                }
                return MovesDB.connector;
            }

            DatabaseConnector connector = new DatabaseConnector();
            connector.SetDatabase(Database);
            await connector.IsConnected();
            MovesDB.connector = connector;
            return connector;
        }
    }
}
