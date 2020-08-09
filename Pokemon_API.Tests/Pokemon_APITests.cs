using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.APIGatewayEvents;

using Pokemon_API;

using Pokemon_API.DataBaseInterface;

namespace Pokemon_API.Tests
{
    public class Pokemon_APITests
    {
        public Pokemon_APITests()
        {
        }

        [Fact]
        public async void TestDBSchemaConnections() {
            DatabaseConnector connection;
            bool isConnected = false;

            connection = DatabaseSchemas.DamageMultiplier.Interface.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            connection = DatabaseSchemas.Moves.Interface.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            connection = DatabaseSchemas.Moves.Interface.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();
        }

    }
}
