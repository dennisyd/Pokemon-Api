/* <copyright file="DarkSky_Microservice.Extensions.APIGatewayProxyResponseExtensions.cs" company="S.I.D" author="Dan Flanagan">
 * Copyright (C) 2019 S.I.D LLC.
 * </copyright>
 * ----------------------------
 */

using System.Collections.Generic;

using Amazon.Lambda.APIGatewayEvents;

namespace DarkSkyMicroservice.Extensions
{
    public static class APIGatewayProxyResponseExtensions
    {
        public static APIGatewayProxyResponse InvalidJson(string errorMsg)
        {
            APIGatewayProxyResponse response = new APIGatewayProxyResponse
            {
                StatusCode = 400,
                Body = $"Invalid JSON {errorMsg}",
                Headers = new Dictionary<string, string> {
                    { "Content-Type", "text/plain" },
                    { "Access-Control-Allow-Methods", "DELETE,GET,HEAD,OPTIONS,PATCH,POST,PUT" },
                    { "Access-Control-Allow-Headers", "Content-Type,Authorization,X-Amz-Date,X-Api-Key,X-Amz-Security-Token" },
                    { "Access-Control-Allow-Origin", "*" },
                    { "Access-Control-Allow-Credentials", "true"}
                }
            };
            return response;
        }

        public static APIGatewayProxyResponse Fail(string body)
        {
            APIGatewayProxyResponse response = new APIGatewayProxyResponse
            {
                StatusCode = 400,
                Body = body,
                Headers = new Dictionary<string, string> {
                    { "Content-Type", "text/plain" },
                    { "Access-Control-Allow-Methods", "DELETE,GET,HEAD,OPTIONS,PATCH,POST,PUT" },
                    { "Access-Control-Allow-Headers", "Content-Type,Authorization,X-Amz-Date,X-Api-Key,X-Amz-Security-Token" },
                    { "Access-Control-Allow-Origin", "*" },
                    { "Access-Control-Allow-Credentials", "true"}
                }
            };
            return response;
        }

        public static APIGatewayProxyResponse Sucess(string body)
        {
            APIGatewayProxyResponse response = new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Body = body,
                Headers = new Dictionary<string, string> {
                    { "Content-Type", "application/json" },
                    { "Access-Control-Allow-Methods", "DELETE,GET,HEAD,OPTIONS,PATCH,POST,PUT" },
                    { "Access-Control-Allow-Headers", "Content-Type,Authorization,X-Amz-Date,X-Api-Key,X-Amz-Security-Token" },
                    { "Access-Control-Allow-Origin", "*" },
                    { "Access-Control-Allow-Credentials", "true"}
                }
            };
            return response;
        }

        public static APIGatewayProxyResponse SetHeaders(this APIGatewayProxyResponse response)
        {
            if (response.Headers == null)
            {
                response.Headers = new Dictionary<string, string>();
            }
            response.Headers["Access-Control-Allow-Methods"] = "DELETE,GET,HEAD,OPTIONS,PATCH,POST,PUT";
            response.Headers["Access-Control-Allow-Headers"] = "Content-Type,Authorization,X-Amz-Date,X-Api-Key,X-Amz-Security-Token";
            response.Headers["Access-Control-Allow-Origin"] = "*";
            response.Headers["Access-Control-Allow-Credentials"] = "true";
            return response;
        }
    }
}
