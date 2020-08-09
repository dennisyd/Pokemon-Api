using System;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class GenderRatio
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "pokemonNumber", Order = 2)]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="male", Order = 3)]
        public float Male { get; set; }

        [JsonProperty(PropertyName="female", Order = 4)]
        public float Female { get; set; }

        public GenderRatio()
        {
        }
    }
}
