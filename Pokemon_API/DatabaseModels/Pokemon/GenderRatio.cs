using System;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseModels.Pokemon
{
    public class GenderRatio
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public string Id { get; set; }

        [JsonProperty(PropertyName="male", Order = 2)]
        public float Male { get; set; }

        [JsonProperty(PropertyName="female", Order = 3)]
        public float Female { get; set; }

        public GenderRatio()
        {
        }
    }
}
