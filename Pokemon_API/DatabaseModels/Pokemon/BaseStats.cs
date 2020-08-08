using System;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseModels.Pokemon
{
    public class BaseStats
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int Id { get; set; }

        [JsonProperty(PropertyName="hp", Order = 2)]
        public int Hp { get; set; }

        [JsonProperty(PropertyName="attack", Order = 3)]
        public int Attack { get; set; }

        [JsonProperty(PropertyName="defense", Order = 4)]
        public int Defense { get; set; }

        [JsonProperty(PropertyName="specialAttack", Order = 5)]
        public int SpecialAttack { get; set; }

        [JsonProperty(PropertyName="specialDefense", Order = 6)]
        public int SpecialDefense { get; set; }

        [JsonProperty(PropertyName="speed", Order = 7)]
        public int Speed { get; set; }


        public BaseStats()
        {
        }
    }
}
