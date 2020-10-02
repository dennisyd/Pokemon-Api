using Pokemon_API.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_API.DatabaseSchemas.DamageMultiplier
{
    public static class DamageMultiplierDB
    {
        private static string Database => "DamageMultipliers";

        private static DatabaseConnector connector = null;
        public static async Task<DatabaseConnector> getDBConnection()
        {
            if (DamageMultiplierDB.connector != null)
            {
                return DamageMultiplierDB.connector;
            }

            DatabaseConnector connector = new DatabaseConnector();
            connector.SetDatabase(Database);
            await connector.IsConnected();
            DamageMultiplierDB.connector = connector;
            return connector;
        }
    }
}
