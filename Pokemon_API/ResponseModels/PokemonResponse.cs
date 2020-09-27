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

        public PokemonResponse(string Name, int Number, string Species, GenderRatio GenderRatio, BaseStats BaseStats,
            List<Moves> Moves, List<string> Abilities, float Height, float Weight, string Color, List<string> Evolutions,
            int? EvolutionLevel, List<string> EggGroups)
        {
            this.Name = Name;
            this.Number = Number;
            this.Species = Species;
            this.GenderRatio = GenderRatio;
            this.BaseStats = BaseStats;
            this.Moves = Moves;
            this.Abilities = Abilities;
            this.Height = Height;
            this.Weight = Weight;
            this.Color = Color;
            this.Evolutions = Evolutions;
            this.EvolutionLevel = EvolutionLevel;
            this.EggGroups = EggGroups;
        }

        public PokemonResponse(Pokemon pokemon, GenderRatio genderRatio, BaseStats baseStats, List<Moves> moves,
            List<string> abilities, List<string> evolutions, List<string> eggGroup)
        {
            this.Name = pokemon.Name;
            this.Number = pokemon.Number;
            this.Species = pokemon.Species;
            this.GenderRatio = genderRatio;
            this.BaseStats = baseStats;
            this.Moves = moves;
            this.Abilities = abilities;
            this.Height = pokemon.Height;
            this.Weight = pokemon.Weight;
            this.Color = pokemon.Color;
            this.Evolutions = evolutions;
            this.EvolutionLevel = pokemon.EvolutionLevel;
            this.EggGroups = eggGroup;
        }
    }
}
