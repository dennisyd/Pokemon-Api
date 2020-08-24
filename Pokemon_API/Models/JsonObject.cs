
using System;

using Newtonsoft.Json;

namespace Pokemon_API.Models
{
    public abstract class JsonObject : IJsonifiable
    {
        public static T FromJson<T>(string jsonString) where T : IJsonifiable
        {
            T newObject = JsonConvert.DeserializeObject<T>(jsonString);

            if (!newObject.IsValid)
            {
                throw new FormatException(newObject.ErrorMessage);
            }
            return newObject;
        }

        [JsonIgnore]
        public abstract bool IsValid
        {
            get;
        }

        [JsonIgnore]
        public abstract string ErrorMessage
        {
            get;
        }
    }
}
