using System;

using Newtonsoft.Json;

namespace Pokemon_API.RequestModels
{
    public class GetPokemon
    {
        [JsonProperty(PropertyName = "name", Order = 1)]
        public string Name { get; set; }

        [JsonProperty(PropertyName="number", Order = 2)]
        public string Number { get; set; }

        [JsonProperty(PropertyName="level", Order = 3)]
        public int Level { get; set; }

        public GetPokemon()
        {
        }
    }
}
