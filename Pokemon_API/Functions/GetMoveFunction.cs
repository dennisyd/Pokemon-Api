using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

using Newtonsoft.Json;

using Pokemon_API.Extensions;
using Pokemon_API.ResponseModels;
using Pokemon_API.DatabaseSchemas.Moves;

namespace Pokemon_API.Functions
{
    public class GetMoveFunction
    {
        public GetMoveFunction()
        {
        }

        public async Task<APIGatewayProxyResponse> FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
        {
            string id = request.PathParameters["id"];

            if (string.IsNullOrEmpty(id))
            {
                return APIGatewayProxyResponseExtensions.Fail($"Please enter pokemon name or number");
            }

            id = Uri.UnescapeDataString(id);

            try
            {
                MoveResponse jsonResponse = await GetResponse(id);
                if (jsonResponse == null)
                {
                    return APIGatewayProxyResponseExtensions.Fail($"Pokemon: {id} not found");
                }
                return APIGatewayProxyResponseExtensions.Sucess(JsonConvert.SerializeObject(jsonResponse));
            }
            catch (Exception e)
            {
                context.Logger.Log(e.Message);
                return APIGatewayProxyResponseExtensions.Fail(e.Message);
            }
        }

        public async Task<MoveResponse> GetResponse(string id)
        {
            MoveResponse response = await new Builder().Build(id);
            return response;
        }
    }
}

