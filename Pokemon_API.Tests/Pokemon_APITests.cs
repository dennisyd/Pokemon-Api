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
        public async void Test_DamageMultiplier_Multiplier()
        {
            Console.WriteLine("-- | Damage Multipliers | Multipliers | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            var table = new DatabaseSchemas.DamageMultiplier.Tables.Multiplier();
            connection = table.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.DamageMultiplier.Models.Multiplier(
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

            await table.Delete(data.Name);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get --");

            DatabaseSchemas.DamageMultiplier.Models.Multiplier get = await table.Get(data.Name);

            Assert.NotNull(get.Id);
            data.Id = get.Id;
            Assert.Equal(data, get);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete --");

            result = await table.Delete(data.Name);
            Assert.NotNull(result);

            get = await table.Get(get.Name);
            Assert.Null(get);

            Console.WriteLine(SUCCESS);
        }

        [Fact]
        public async void Test_Moves_Flags()
        {
            Console.WriteLine("-- | Moves | Flags | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            var table = new DatabaseSchemas.Moves.Tables.Flags();
            connection = table.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Moves.Models.Flags(
                Id: null,
                MoveNumber: -1,
                Flag: "test"
            );

            await table.Delete(data.MoveNumber);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get --");

            List<DatabaseSchemas.Moves.Models.Flags> flags = await table.Get(data.MoveNumber);
            DatabaseSchemas.Moves.Models.Flags get = flags.FirstOrDefault();

            Assert.NotNull(get);
            Assert.NotNull(get.Id);

            data.Id = get.Id;
            Assert.Equal(data, get);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete --");

            result = await table.Delete(data.MoveNumber);
            Assert.NotNull(result);

            flags = await table.Get(data.MoveNumber);
            Assert.Empty(flags);

            Console.WriteLine(SUCCESS);
        }

        [Fact]
        public async void Test_Moves_Moves()
        {
            Console.WriteLine("-- | Moves | Move | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            var table = new DatabaseSchemas.Moves.Tables.Move();
            connection = table.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Moves.Models.Moves(
                Id: null,
                Name: "test",
                Number: -1,
                Accuracy: -2,
                BasePower: -3,
                Category: "category",
                Description: "description",
                ShortDescription: "shortDescription",
                PP: -4,
                Priority: -5,
                CritRatio: -6,
                Target: "target",
                Type: "type",
                ContestType: "contestType"
            ); 

            await table.Delete(data.Name);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get --");

            DatabaseSchemas.Moves.Models.Moves get = await table.Get(data.Name);

            Assert.NotNull(get);
            Assert.NotNull(get.Id);

            data.Id = get.Id;
            Assert.Equal(data, get);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete --");

            result = await table.Delete(data.Name);
            Assert.NotNull(result);

            get = await table.Get(data.Name);
            Assert.Null(get);

            Console.WriteLine(SUCCESS);
        }

        [Fact]
        public async void Test_Pokemon_Abilities()
        {
            Console.WriteLine("-- | Pokemon | Abilities | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            var table = new DatabaseSchemas.Pokemon.Tables.Abilities();
            connection = table.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.Abilities(
                Id: null,
                PokemonNumber: -1,
                Ability: "ability"
            );

            await table.Delete(data.PokemonNumber);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get --");

            List<DatabaseSchemas.Pokemon.Models.Abilities> list = await table.Get(data.PokemonNumber);
            var get = list.FirstOrDefault();

            Assert.NotNull(get);
            Assert.NotNull(get.Id);

            data.Id = get.Id;
            Assert.Equal(data, get);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete --");

            result = await table.Delete(data.PokemonNumber);
            Assert.NotNull(result);

            list = await table.Get(data.PokemonNumber);
            Assert.Empty(list);

            Console.WriteLine(SUCCESS);
        }

        [Fact]
        public async void Test_Pokemon_BaseStats()
        {
            Console.WriteLine("-- | Pokemon | BaseStats | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            var table = new DatabaseSchemas.Pokemon.Tables.BaseStats();
            connection = table.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.BaseStats(
                Id: null,
                PokemonNumber: -1,
                Hp: -2,
                Attack: -3,
                Defense: -4,
                SpecialAttack: -5,
                SpecialDefense: -6,
                Speed: -7
            );

            await table.Delete(data.PokemonNumber);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get --");

            DatabaseSchemas.Pokemon.Models.BaseStats get = await table.Get(data.PokemonNumber);

            Assert.NotNull(get);
            Assert.NotNull(get.Id);

            data.Id = get.Id;
            Assert.Equal(data, get);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete --");

            result = await table.Delete(data.PokemonNumber);
            Assert.NotNull(result);

            get = await table.Get(data.PokemonNumber);
            Assert.Null(get);

            Console.WriteLine(SUCCESS);
        }

        [Fact]
        public async void Test_Pokemon_Evolutions()
        {
            Console.WriteLine("-- | Pokemon | Evolutions | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            var table = new DatabaseSchemas.Pokemon.Tables.Evolutions();
            connection = table.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.Evolutions(
                Id: null,
                PokemonNumber: -1,
                Evolution: "evolution"
            );

            await table.Delete(data.PokemonNumber);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get --");

            List<DatabaseSchemas.Pokemon.Models.Evolutions> list = await table.Get(data.PokemonNumber);
            var get = list.FirstOrDefault();

            Assert.NotNull(get);
            Assert.NotNull(get.Id);

            data.Id = get.Id;
            Assert.Equal(data, get);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete --");

            result = await table.Delete(data.PokemonNumber);
            Assert.NotNull(result);

            list = await table.Get(data.PokemonNumber);
            Assert.Empty(list);

            Console.WriteLine(SUCCESS);
        }

        [Fact]
        public async void Test_Pokemon_GenderRatio()
        {
            Console.WriteLine("-- | Pokemon | GenderRatio | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            var table = new DatabaseSchemas.Pokemon.Tables.GenderRatio();
            connection = table.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.GenderRatio(
                Id: null,
                PokemonNumber: -1,
                Male: 1f,
                Female: 2f
            );

            await table.Delete(data.PokemonNumber);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get --");

            DatabaseSchemas.Pokemon.Models.GenderRatio get = await table.Get(data.PokemonNumber);

            Assert.NotNull(get);
            Assert.NotNull(get.Id);

            data.Id = get.Id;
            Assert.Equal(data, get);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete --");

            result = await table.Delete(data.PokemonNumber);
            Assert.NotNull(result);

            get = await table.Get(data.PokemonNumber);
            Assert.Null(get);

            Console.WriteLine(SUCCESS);
        }

        [Fact]
        public async void Test_Pokemon_Moves()
        {
            Console.WriteLine("-- | Pokemon | Moves | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            var table = new DatabaseSchemas.Pokemon.Tables.Moves();
            connection = table.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.Moves(
                Id: null,
                PokemonNumber: -1,
                MoveNumber: -2,
                Level: -3,
                IsTM: false,
                IsHM: false
            );

            await table.Delete(data.PokemonNumber);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get --");

            List<DatabaseSchemas.Pokemon.Models.Moves> list = await table.Get(data.PokemonNumber);
            var get = list.FirstOrDefault();

            Assert.NotNull(get);
            Assert.NotNull(get.Id);

            data.Id = get.Id;
            Assert.Equal(data, get);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete --");

            result = await table.Delete(data.PokemonNumber);
            Assert.NotNull(result);

            list = await table.Get(data.PokemonNumber);
            Assert.Empty(list);

            Console.WriteLine(SUCCESS);
        }

        [Fact]
        public async void Test_Pokemon_Pokemon()
        {
            Console.WriteLine("-- | Pokemon | Pokemon | --");
            Console.WriteLine("-- Testing Connection --");
            DatabaseConnector connection;
            bool isConnected;

            var table = new DatabaseSchemas.Pokemon.Tables.Pokemon();
            connection = table.GetDatabaseConnector();
            isConnected = await connection.IsConnected();
            Assert.True(isConnected);
            await connection.Disconnect();

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.Pokemon(
                Id: null,
                Name: "test",
                Number: -1,
                Species: "species",
                Height: -2f,
                Weight: -3f,
                Color: "color",
                EvolutionLevel: null
            );

            await table.Delete(data.Number);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get Name --");

            DatabaseSchemas.Pokemon.Models.Pokemon getName = await table.Get(data.Name);

            Assert.NotNull(getName);
            Assert.NotNull(getName.Id);

            data.Id = getName.Id;
            Assert.Equal(data, getName);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete Name--");

            result = await table.Delete(data.Name);
            Assert.NotNull(result);

            getName = await table.Get(data.Name);
            Assert.Null(getName);

            Console.WriteLine("-- Testing Insert --");
            result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);

            Console.WriteLine("-- Testing Get Number --");
            DatabaseSchemas.Pokemon.Models.Pokemon getNumber = await table.Get(data.Number);

            Assert.NotNull(getNumber);
            Assert.NotNull(getNumber.Id);

            data.Id = getNumber.Id;
            Assert.Equal(data, getNumber);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete Number --");

            result = await table.Delete(data.Number);
            Assert.NotNull(result);

            getName = await table.Get(data.Number);
            Assert.Null(getName);

            Console.WriteLine(SUCCESS);
        }
    }
}
