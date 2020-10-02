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
using Pokemon_API.DatabaseSchemas.Pokemon;

namespace Pokemon_API.Tests
{
    [Collection("Sequential")]
    public class PokemonDBTests
    {
        const string SUCCESS = "SUCCESS";

        public PokemonDBTests()
        {
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
        public async void Test_Pokemon_Abilities()
        {
            Console.WriteLine("-- | Pokemon | Abilities | --");

            var table = new DatabaseSchemas.Pokemon.Tables.Abilities();

            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.Abilities(
                id: null,
                pokemonNumber: -1,
                ability1: "ability"
            );

            await table.Delete(data.PokemonNumber);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get --");

            DatabaseSchemas.Pokemon.Models.Abilities get = await table.Get(data.PokemonNumber);

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
        public async void Test_Pokemon_BaseStats()
        {
            Console.WriteLine("-- | Pokemon | BaseStats | --");

            var table = new DatabaseSchemas.Pokemon.Tables.BaseStats();

            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.BaseStats(
                id: null,
                pokemonNumber: -1,
                hp: -2,
                attack: -3,
                defense: -4,
                specialAttack: -5,
                specialDefense: -6,
                speed: -7
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

            var table = new DatabaseSchemas.Pokemon.Tables.Evolutions();

            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.Evolutions(
                id: null,
                pokemonNumber: -1,
                evolution: "evolution"
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

            var table = new DatabaseSchemas.Pokemon.Tables.GenderRatio();

            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.GenderRatio(
                id: null,
                pokemonNumber: -1,
                male: 1f,
                female: 2f
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

            var table = new DatabaseSchemas.Pokemon.Tables.Moves();

            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.Moves(
                id: null,
                pokemonNumber: -1,
                moveNumber: -2,
                level: -3,
                isTM: false,
                isHM: false
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

            var table = new DatabaseSchemas.Pokemon.Tables.Pokemon();

            Console.WriteLine("-- Testing Insert --");

            var data = new DatabaseSchemas.Pokemon.Models.Pokemon(
                id: null,
                name: "test",
                number: -1,
                height_m: -2f,
                weight_kg: -3f,
                color: "color"
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

        [Fact]
        public async void Test_Pokemon_Types()
        {
            Console.WriteLine("-- | Pokemon | Types | --");

            var table = new DatabaseSchemas.Pokemon.Tables.Types();

            Console.WriteLine("-- Testing Insert One Type --");

            var data = new DatabaseSchemas.Pokemon.Models.Types(
                id: null,
                pokemonNumber: -1,
                type1: "type1"
            );

            await table.Delete(data.PokemonNumber);

            int? result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Get One Type --");

            DatabaseSchemas.Pokemon.Models.Types getName = await table.Get(data.PokemonNumber);

            Assert.NotNull(getName);
            Assert.NotNull(getName.Id);

            data.Id = getName.Id;
            Assert.Equal(data, getName);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete Name--");

            result = await table.Delete(data.PokemonNumber);
            Assert.NotNull(result);

            getName = await table.Get(data.PokemonNumber);
            Assert.Null(getName);

            Console.WriteLine("-- Testing Insert Two Types --");

            data = new DatabaseSchemas.Pokemon.Models.Types(
                id: null,
                pokemonNumber: -1,
                type1: "type1",
                type2: "type2"
            );

            result = await table.Insert(data);
            Assert.NotNull(result);

            Console.WriteLine(SUCCESS);

            Console.WriteLine("-- Testing Get Two Types --");
            DatabaseSchemas.Pokemon.Models.Types getNumber = await table.Get(data.PokemonNumber);

            Assert.NotNull(getNumber);
            Assert.NotNull(getNumber.Id);

            data.Id = getNumber.Id;
            Assert.Equal(data, getNumber);

            Console.WriteLine(SUCCESS);
            Console.WriteLine("-- Testing Delete Number --");

            result = await table.Delete(data.PokemonNumber);
            Assert.NotNull(result);

            getName = await table.Get(data.PokemonNumber);
            Assert.Null(getName);

            Console.WriteLine(SUCCESS);
        }
    }
}
