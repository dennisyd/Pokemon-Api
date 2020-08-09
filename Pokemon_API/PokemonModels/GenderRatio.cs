using System;

using Newtonsoft.Json;

namespace Pokemon_API.PokemonModels
{
    public class GenderRatio
    {
        [JsonProperty(PropertyName = "male", Order = 1)]
        public float Male { get; set; }

        [JsonProperty(PropertyName = "female", Order = 2)]
        public float Female { get; set; }

        public GenderRatio()
        {
        }
    }
}
