using System;

using Newtonsoft.Json;

namespace Pokemon_API.PokemonModels
{
    public class BaseStats
    {

        [JsonProperty(PropertyName = "hp", Order = 1)]
        public int Hp { get; set; }

        [JsonProperty(PropertyName = "attack", Order = 2)]
        public int Attack { get; set; }

        [JsonProperty(PropertyName = "defense", Order = 3)]
        public int Defense { get; set; }

        [JsonProperty(PropertyName = "specialAttack", Order = 4)]
        public int SpecialAttack { get; set; }

        [JsonProperty(PropertyName = "specialDefense", Order = 5)]
        public int SpecialDefense { get; set; }

        [JsonProperty(PropertyName = "speed", Order = 6)]
        public int Speed { get; set; }

        public BaseStats()
        {
        }
    }
}
