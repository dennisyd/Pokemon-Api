using System;
using System.Collections.Generic;

using Newtonsoft.Json;


namespace Pokemon_API.PokemonModels
{
    public class Pokemon
    {

        [JsonProperty(PropertyName = "name", Order = 1)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "number", Order = 2)]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "species", Order = 3)]
        public string Species { get; set; }

        [JsonProperty(PropertyName = "genderRatio", Order = 4)]
        public GenderRatio GenderRatio { get; set; }

        [JsonProperty(PropertyName = "baseStats", Order = 5)]
        public BaseStats BaseStats { get; set; }

        [JsonProperty(PropertyName = "levelStats", Order = 6)]
        public BaseStats AdjustedStats { get; set; }

        //[JsonProperty(PropertyName = "moves", Order = 7)]
        //public List<Moves> Moves { get; set; }

        [JsonProperty(PropertyName = "abilities", Order = 8)]
        public List<string> Abilities { get; set; }

        [JsonProperty(PropertyName = "height", Order = 9)]
        public float Height { get; set; }

        [JsonProperty(PropertyName = "weight", Order = 10)]
        public float Weight { get; set; }

        [JsonProperty(PropertyName = "color", Order = 11)]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "previousEvolution", Order = 12)]
        public string PreviousEvolution { get; set; }

        [JsonProperty(PropertyName = "evolutions", Order = 13)]
        public List<string> Evolutions { get; set; }

        [JsonProperty(PropertyName = "evolutionLevel", Order = 14)]
        public int EvolutionLevel { get; set; }

        [JsonProperty(PropertyName = "eggGroups", Order = 15)]
        public List<string> EggGroups { get; set; }

        public Pokemon()
        {
        }
    }
}
