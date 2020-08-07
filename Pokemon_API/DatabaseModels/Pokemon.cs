using System;
using System.Collections.Generic;

using Newtonsoft.JSON;

namespace Pokemon_API.DatabaseModels
{
    public class Pokemon
    {
        //[JsonProperty(propertyName="id", order = 1)]
        public string Id { get; set; }

        //[JsonProperty(propertyName="name", order = 2)]
        public string Name { get; set; }

        //[JsonProperty(propertyName = "number", order = 3)]
        public string Number { get; set; }

        //[JsonProperty(propertyName = "species", order = 4)]
        public string Species { get; set; }

        //[JsonProperty(propertyName = "genderRatio", order = 5)]
        public GenderRatio GenderRatio { get; set; }

        //[JsonProperty(propertyName = "baseStats", order = 6)]
        public BaseStats BaseStats { get; set; }

        //[JsonProperty(propertyName = "abilities", order = 6)]
        public List<string> Abilities { get; set; }

        //[JsonProperty(propertyName = "height", order = 6)]
        public float Height { get; set; }

        //[JsonProperty(propertyName = "weight", order = 6)]
        public float Weight { get; set; }

        //[JsonProperty(propertyName = "color", order = 6)]
        public string Color { get; set; }

        //[JsonProperty(propertyName = "previousEvolution", order = 6)]
        public string PreviousEvolution { get; set; }

        //[JsonProperty(propertyName = "evolutions", order = 6)]
        public List<string> Evolutions { get; set; }

        //[JsonProperty(propertyName = "evolutionLevel", order = 6)]
        public int EvolutionLevel { get; set; }

        //[JsonProperty(propertyName = "eggGroups", order = 6)]
        public List<string> EggGroups { get; set; }

        public Pokemon()
        {
        }
    }
}
