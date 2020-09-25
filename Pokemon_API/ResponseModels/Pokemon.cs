using System.Collections.Generic;

using Newtonsoft.Json;

using Pokemon_API.DatabaseSchemas.Pokemon.Models;

namespace Pokemon_API.ResponseModels
{
    public class Pokemon
    {
        [JsonProperty(PropertyName = "name", Order = 2)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "number", Order = 3)]
        public int Number { get; set; }

        [JsonProperty(PropertyName = "species", Order = 4)]
        public string Species { get; set; }

        [JsonProperty(PropertyName = "genderRatio", Order = 5)]
        public GenderRatio GenderRatio { get; set; }

        [JsonProperty(PropertyName = "baseStats", Order = 6)]
        public BaseStats BaseStats { get; set; }

        [JsonProperty(PropertyName = "moves", Order = 7)]
        public List<Moves> Moves { get; set; }

        [JsonProperty(PropertyName = "abilities", Order = 8)]
        public List<string> Abilities { get; set; }

        [JsonProperty(PropertyName = "height", Order = 9)]
        public float Height { get; set; }

        [JsonProperty(PropertyName = "weight", Order = 10)]
        public float Weight { get; set; }

        [JsonProperty(PropertyName = "color", Order = 11)]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "evolutions", Order = 12)]
        public List<string> Evolutions { get; set; }

        [JsonProperty(PropertyName = "evolutionLevel", Order = 13, NullValueHandling = NullValueHandling.Ignore)]
        public int? EvolutionLevel { get; set; }

        [JsonProperty(PropertyName = "eggGroups", Order = 14)]
        public List<string> EggGroups { get; set; }

        public Pokemon()
        {
        }
    }
}
