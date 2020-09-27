using System.Collections.Generic;

using Newtonsoft.Json;

using Pokemon_API.DatabaseSchemas.Pokemon.Models;

namespace Pokemon_API.ResponseModels
{
    public class PokemonResponse
    {
        [JsonProperty(PropertyName = "name", Order = 1)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "number", Order = 2)]
        public int Number { get; set; }

        [JsonProperty(PropertyName = "species", Order = 3)]
        public string Species { get; set; }

        [JsonProperty(PropertyName = "genderRatio", Order = 4)]
        public GenderRatio GenderRatio { get; set; }

        [JsonProperty(PropertyName = "baseStats", Order = 5)]
        public BaseStats BaseStats { get; set; }

        [JsonProperty(PropertyName = "moves", Order = 6)]
        public List<Moves> Moves { get; set; }

        [JsonProperty(PropertyName = "abilities", Order = 7)]
        public List<string> Abilities { get; set; }

        [JsonProperty(PropertyName = "height", Order = 8)]
        public float Height { get; set; }

        [JsonProperty(PropertyName = "weight", Order = 9)]
        public float Weight { get; set; }

        [JsonProperty(PropertyName = "color", Order = 10)]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "evolutions", Order = 11)]
        public List<string> Evolutions { get; set; }

        [JsonProperty(PropertyName = "evolutionLevel", Order = 12, NullValueHandling = NullValueHandling.Ignore)]
        public int? EvolutionLevel { get; set; }

        [JsonProperty(PropertyName = "eggGroups", Order = 13)]
        public List<string> EggGroups { get; set; }

        public PokemonResponse()
        {
        }
    }
}
