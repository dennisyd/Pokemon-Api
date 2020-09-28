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
using Pokemon_API.DatabaseSchemas.DamageMultiplier;

namespace Pokemon_API.Functions
{
    public class GetDamageMultiplierFunction
    {
        public GetDamageMultiplierFunction()
        {
        }

        public async Task<APIGatewayProxyResponse> FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
        {
            string type1 = request.PathParameters["type1"];
            string type2 = request.PathParameters["type2"];

            if (string.IsNullOrEmpty(type1))
            {
                return APIGatewayProxyResponseExtensions.Fail($"Please enter atleast one pokemon type");
            }

            type1 = Uri.UnescapeDataString(type1);
            type2 = Uri.UnescapeDataString(type2);

            try
            {
                MultiplierResponse jsonResponse = await GetResponse(type1, type2);
                if (jsonResponse == null)
                {
                    return APIGatewayProxyResponseExtensions.Fail($"Damage Multipler: {type1} not found");
                }
                return APIGatewayProxyResponseExtensions.Sucess(JsonConvert.SerializeObject(jsonResponse));
            }
            catch (Exception e)
            {
                context.Logger.Log(e.Message);
                return APIGatewayProxyResponseExtensions.Fail(e.Message);
            }
        }

        public async Task<MultiplierResponse> GetResponse(string t1, string t2)
        {
            Builder builder = new Builder();
            MultiplierResponse type1  = await builder.Build(t1);

            if (string.IsNullOrEmpty(t2))
            {
                return type1;
            }

            MultiplierResponse type2 = await builder.Build(t2);
            return builder.CombineTypes(type1, type2);
        }
    }
}
