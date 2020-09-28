﻿using System;
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
    public class MovesDBTests
    {
        const string SUCCESS = "SUCCESS";

        public MovesDBTests()
        {
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
                id: null,
                moveNumber: -1,
                flag: "test"
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
                id: null,
                name: "test",
                number: -1,
                accuracy: -2,
                basePower: -3,
                category: "category",
                description: "description",
                shortDescription: "shortDescription",
                pp: -4,
                priority: -5,
                critRatio: -6,
                target: "target",
                type: "type",
                contestType: "contestType"
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
    }
}