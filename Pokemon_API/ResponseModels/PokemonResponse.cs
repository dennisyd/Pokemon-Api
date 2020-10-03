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

        [JsonProperty(PropertyName = "types", Order = 3)]
        public List<string> Types { get; set; }

        [JsonProperty(PropertyName = "genderRatio", Order = 4, NullValueHandling = NullValueHandling.Ignore)]
        public GenderRatio GenderRatio { get; set; }

        [JsonProperty(PropertyName = "baseStats", Order = 5)]
        public BaseStats BaseStats { get; set; }

        [JsonProperty(PropertyName = "moves", Order = 6, NullValueHandling = NullValueHandling.Ignore)]
        public List<Moves> Moves { get; set; }

        [JsonProperty(PropertyName = "abilities", Order = 7)]
        public List<string> Abilities { get; set; }

        [JsonProperty(PropertyName = "height", Order = 8)]
        public float Height { get; set; }

        [JsonProperty(PropertyName = "weight", Order = 9)]
        public float Weight { get; set; }

        [JsonProperty(PropertyName = "color", Order = 10)]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "evolutions", Order = 11, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Evolutions { get; set; }

        [JsonProperty(PropertyName = "evolutionLevel", Order = 12, NullValueHandling = NullValueHandling.Ignore)]
        public int? EvolutionLevel { get; set; }

        [JsonProperty(PropertyName = "eggGroups", Order = 13, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EggGroups { get; set; }

        public PokemonResponse()
        {
        }

        public PokemonResponse(Pokemon pokemon, GenderRatio genderRatio, BaseStats baseStats, List<Moves> moves,
            List<string> abilities, List<string> evolutions, List<string> eggGroup, List<string> types)
        {
            this.Name = pokemon.Name;
            this.Number = pokemon.Number;
            this.Types = types;
            this.GenderRatio = genderRatio;
            this.BaseStats = baseStats;
            this.Moves = moves;
            this.Abilities = (abilities != null) ? (abilities.Count == 0) ? null : abilities : abilities;
            this.Height = pokemon.Height_M;
            this.Weight = pokemon.Weight_Kg;
            this.Color = pokemon.Color;
            this.Evolutions = (evolutions != null) ? (evolutions.Count == 0) ? null : evolutions : evolutions;
            this.EvolutionLevel = pokemon.EvoLevel;
            this.EggGroups = (eggGroup != null) ? (eggGroup.Count == 0) ? null : eggGroup : eggGroup;
        }
    }
}
