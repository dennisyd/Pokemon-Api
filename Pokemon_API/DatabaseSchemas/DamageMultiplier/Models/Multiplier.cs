using System;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.DamageMultiplier.Models
{
    public class Multiplier
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int Id{ get; set; }

        [JsonProperty(PropertyName="name", Order = 2)]
        public int Name { get; set; }

        [JsonProperty(PropertyName="normal", Order = 3)]
        public float Normal{ get; set; }

        [JsonProperty(PropertyName="fighting", Order = 4)]
        public float Fighting{ get; set; }

        [JsonProperty(PropertyName="flying", Order = 5)]
        public float Flying{ get; set; }

        [JsonProperty(PropertyName="poison", Order = 6)]
        public float Poison{ get; set; }

        [JsonProperty(PropertyName="ground", Order = 7)]
        public float Ground{ get; set; }

        [JsonProperty(PropertyName="rock", Order = 8)]
        public float Rock{ get; set; }

        [JsonProperty(PropertyName="bug", Order = 9)]
        public float Bug{ get; set; }

        [JsonProperty(PropertyName="ghost", Order = 10)]
        public float Ghost{ get; set; }

        [JsonProperty(PropertyName="steel", Order = 11)]
        public float Steel{ get; set; }

        [JsonProperty(PropertyName="fire", Order = 12)]
        public float Fire{ get; set; }

        [JsonProperty(PropertyName="water", Order = 13)]
        public float Water{ get; set; }

        [JsonProperty(PropertyName="grass", Order = 14)]
        public float Grass{ get; set; }

        [JsonProperty(PropertyName="electric", Order = 15)]
        public float Electric{ get; set; }

        [JsonProperty(PropertyName="psychic", Order = 16)]
        public float Psychic{ get; set; }

        [JsonProperty(PropertyName="ice", Order = 17)]
        public float Ice{ get; set; }

        [JsonProperty(PropertyName="dragon", Order = 18)]
        public float Dragon{ get; set; }

        [JsonProperty(PropertyName="dark", Order = 19)]
        public float Dark{ get; set; }

        [JsonProperty(PropertyName="fairy", Order = 20)]
        public float Fairy{ get; set; }

        public Multiplier()
        {
        }
    }
}
