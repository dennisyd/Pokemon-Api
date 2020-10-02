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
        public async void TestDBSchemaConnections()
        {

            Console.WriteLine("-- | Damage Multipliers | Multipliers | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            var multiplier = new DatabaseSchemas.DamageMultiplier.Tables.Multiplier();

            Console.WriteLine(multiplier.Database);
            Console.WriteLine(multiplier.TableName);

            connection = multiplier.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);

            Console.WriteLine("-- | Moves | Flags | --");
            Console.WriteLine("-- Testing Connection --");

            var moves = new DatabaseSchemas.Moves.Tables.Flags();
            connection = moves.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);

            Console.WriteLine("-- | Pokemon | BaseStats | --");
            Console.WriteLine("-- Testing Connection --");

            var pokemon = new DatabaseSchemas.Pokemon.Tables.BaseStats();
            connection = pokemon.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
        }

        [Fact]
        public async void TestGetPokemon()
        {
            ResponseModels.PokemonResponse pokemon = await (new DatabaseSchemas.Pokemon.Builder().Build(1));

            Assert.NotNull(pokemon);

            pokemon = await (new DatabaseSchemas.Pokemon.Builder().Build("bulbasaur"));

            Assert.NotNull(pokemon);
        }

        [Fact]
        public async void TestGetMultiplier()
        {
            ResponseModels.MultiplierResponse dmgMult = await (new DatabaseSchemas.DamageMultiplier.Builder().Build("normal"));

            Assert.NotNull(dmgMult);
        }

        [Fact]
        public async void TestGetMove()
        {
            ResponseModels.MoveResponse move = await (new DatabaseSchemas.Moves.Builder().Build(1));

            Assert.NotNull(move);
        }
    }
}
