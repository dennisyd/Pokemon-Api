/* <copyright file="DarkSky_Microservice.Extensions.RestSharpExtensions.cs" company="S.I.D" author="Dan Flanagan">
 * Copyright (C) 2019 S.I.D LLC.
 * </copyright>
 * ----------------------------
 */

using System;

using Newtonsoft.Json;

using RestSharp;

namespace Pokemon_API.Extensions
{
    public static class RestSharpExtensions
    {
        private const string Host = "Host";
        private const string ContentType = "Content-Type";
        private const string CacheControl = "Cache-Control";
        private const string NoCache = "no-cache";
        private const string JsonContentType = "application/json";

        public static RestRequest GetRequest()
        {
            return new RestRequest(Method.GET);
        }

        public static RestRequest PostRequest()
        {
            return new RestRequest(Method.POST);
        }

        public static RestRequest PutRequest()
        {
            return new RestRequest(Method.PUT);
        }

        public static RestRequest PatchRequest()
        {
            return new RestRequest(Method.PATCH);
        }

        public static RestRequest SetHost(this RestRequest request, string url)
        {
            request.AddHeader(Host, url);
            return request;
        }

        public static RestRequest SetContentType(this RestRequest request, string type)
        {
            request.AddHeader(ContentType, type);
            return request;
        }

        public static RestRequest SetCache(this RestRequest request, string cache = default(string))
        {
            cache = (string.IsNullOrEmpty(cache)) ? NoCache : cache;
            request.AddHeader(CacheControl, NoCache);
            return request;
        }

        public static RestRequest SetJsonBody(this RestRequest request, object body)
        {
            string content = JsonConvert.SerializeObject(body);
            request.AddParameter(JsonContentType, content, ParameterType.RequestBody);
            return request;
        }

        public static void Log(this IRestResponse response, bool displayContent = false)
        {
            Console.WriteLine($"{response.ResponseUri} : {response.IsSuccessful} : {response.StatusDescription}");

            if (!string.IsNullOrEmpty(response.ErrorMessage))
            {
                Console.WriteLine(response.ErrorMessage);
            }

            if (response.ErrorException != null && !string.IsNullOrEmpty(response.ErrorException.Message))
            {
                Console.WriteLine(response.ErrorException.Message);
            }

            if (displayContent)
            {
                Console.WriteLine(response.Content);
            }
        }
    }
}