using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using Amazon.Lambda.APIGatewayEvents;

using Pokemon_API;

using Pokemon_API.Extensions;

namespace Pokemon_API.Tests
{
    public class Pokemon_APITests
    {
        const string SUCCESS = "SUCCESS";

        public Pokemon_APITests()
        {
        }

        [Fact]
        public async void TestDBSchemaConnections() {
            DatabaseConnector connection;
            bool isConnected;

            DatabaseSchemas.DamageMultiplier.Tables.Multiplier multiplier = new DatabaseSchemas.DamageMultiplier.Tables.Multiplier();

            Console.WriteLine(multiplier.Database);
            Console.WriteLine(multiplier.TableName);

            connection = multiplier.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            /*
            connection = DatabaseSchemas.Moves.Interface.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            connection = DatabaseSchemas.Moves.Interface.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();
            */
        }

        [Fact]
        public async void TestDamageMultiplier()
        {
            Console.WriteLine("-- | Damage Multipliers | Multipliers | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            DatabaseSchemas.DamageMultiplier.Tables.Multiplier multiplier = new DatabaseSchemas.DamageMultiplier.Tables.Multiplier();
            connection = multiplier.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Insert --");

            DatabaseSchemas.DamageMultiplier.Models.Multiplier data = new DatabaseSchemas.DamageMultiplier.Models.Multiplier(
                Id: null,
                Name: "test",
                Normal: 10,
                Fighting: 10,
                Flying: 10,
                Poison: 10,
                Ground: 10,
                Rock: 10,
                Bug: 10,
                Ghost: 10,
                Steel: 10,
                Fire: 10,
                Water: 10,
                Grass: 10,
                Electric: 10,
                Psychic: 10,
                Ice: 10,
                Dragon: 10,
                Dark: 10,
                Fairy: 10
            );

            await multiplier.Delete(data.Name);

            int? result = await multiplier.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get --");

            DatabaseSchemas.DamageMultiplier.Models.Multiplier get = await multiplier.Get(data.Name);

            Assert.NotNull(get.Id);
            data.Id = get.Id;
            Assert.Equal(data, get);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete --");

            result = await multiplier.Delete(data.Name);
            Assert.NotNull(result);

            get = await multiplier.Get(get.Name);
            Assert.Null(get);

            Console.WriteLine(SUCCESS);
        }
    }
}
