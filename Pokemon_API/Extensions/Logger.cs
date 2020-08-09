/* <copyright file="DarkSky_Microservice.Extensions.Logger.cs" company="S.I.D" author="Dan Flanagan">
 * Copyright (C) 2019 S.I.D LLC.
 * </copyright>
 * ----------------------------
 */

using System;

using Newtonsoft.Json;

namespace DarkSkyMicroservice.Extensions
{
    public static class Logger
    {
        public static void WriteLine(string s)
        {
            Console.WriteLine(s);
        }

        public static void WriteJson(object o)
        {
            Console.WriteLine(JsonConvert.SerializeObject(o, Formatting.Indented));
        }

        public static void WriteRequest(RestSharp.IRestResponse restResponse, bool writeContent)
        {
            if (restResponse.ResponseUri != null)
            {
                Console.WriteLine($"{restResponse.ResponseUri} : {restResponse.IsSuccessful} : {restResponse.StatusDescription.ToString()}");
            }

            if (!string.IsNullOrEmpty(restResponse.ErrorMessage))
            {
                Console.WriteLine(restResponse.ErrorMessage + "\n");
            }

            if (restResponse.ErrorException != null && !string.IsNullOrEmpty(restResponse.ErrorException.Message))
            {
                Console.WriteLine(restResponse.ErrorException.Message + "\n");
            }

            if (!string.IsNullOrEmpty(restResponse.Content) && writeContent)
            {
                //Console.WriteLine(JsonConvert.SerializeObject(restResponse.Content, Formatting.Indented));
                Console.WriteLine(restResponse.Content + "\n");
            }
        }
    }
}