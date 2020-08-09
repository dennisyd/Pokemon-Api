/* <copyright file="DarkSky_Microservice.Extensions.RestfulAPI.cs" company="S.I.D" author="Dan Flanagan">
 * Copyright (C) 2019 S.I.D LLC.
 * </copyright>
 * ----------------------------
 */

using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

using RestSharp;

namespace DarkSkyMicroservice.Extensions
{
    public static class RestfulAPI
    {
        private static async Task<IRestResponse> Async(RestSharp.Method method, string url, object body = default(object), NetworkCredential creds = null, Dictionary<string, string> headers = null)
        {
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(method);

            if (creds != null)
            {
                request.Credentials = creds;
            }
            if (body != null && body != default(object))
            {
                request.AddJsonBody(body);
            }

            if (headers != null && headers.Count > 0)
            {
                foreach (KeyValuePair<string, string> pair in headers)
                {
                    request.AddHeader(pair.Key, pair.Value);
                }
            }

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            IRestResponse restResponse = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);
            if (restResponse == null)
            {
                Logger.WriteLine("null rest response");
            }
            else
            {
                Logger.WriteRequest(restResponse, false);
            }

            return restResponse;
        }

        public static async Task<IRestResponse> CopyAsync(string url, object body = default(object), NetworkCredential creds = null, Dictionary<string, string> headers = null)
        {
            return await Async(Method.COPY, url, body, creds, headers);
        }

        public static async Task<IRestResponse> DeleteAsync(string url, object body = default(object), NetworkCredential creds = null, Dictionary<string, string> headers = null)
        {
            return await Async(Method.DELETE, url, body, creds, headers);
        }

        public static async Task<IRestResponse> GetAsync(string url, object body = default(object), NetworkCredential creds = null, Dictionary<string, string> headers = null)
        {
            return await Async(Method.GET, url, body, creds, headers);
        }

        public static async Task<IRestResponse> HeadAsync(string url, object body = default(object), NetworkCredential creds = null, Dictionary<string, string> headers = null)
        {
            return await Async(Method.HEAD, url, body, creds, headers);
        }

        public static async Task<IRestResponse> MergeAsync(string url, object body = default(object), NetworkCredential creds = null, Dictionary<string, string> headers = null)
        {
            return await Async(Method.MERGE, url, body, creds, headers);
        }

        public static async Task<IRestResponse> OptionsAsync(string url, object body = default(object), NetworkCredential creds = null, Dictionary<string, string> headers = null)
        {
            return await Async(Method.OPTIONS, url, body, creds, headers);
        }

        public static async Task<IRestResponse> PatchAsync(string url, object body = default(object), NetworkCredential creds = null, Dictionary<string, string> headers = null)
        {
            return await Async(Method.PATCH, url, body, creds, headers);
        }

        public static async Task<IRestResponse> PostAsync(string url, object body = default(object), NetworkCredential creds = null, Dictionary<string, string> headers = null)
        {
            return await Async(Method.POST, url, body, creds, headers);
        }

        public static async Task<IRestResponse> PutAsync(string url, object body = default(object), NetworkCredential creds = null, Dictionary<string, string> headers = null)
        {
            return await Async(Method.PUT, url, body, creds, headers);
        }
    }
}