using System;

using Newtonsoft.JSON;

namespace Pokemon_API.DatabaseModels.Pokemon
{
    public class EggGroups
    {
        //[JsonProperty(propertyName="id", order = 1)]
        public int Id { get; set; }

        //[JsonProperty(propertyName="pokemonNumber", order = 2)]
        public int PokemonNumber { get; set; }

        //[JsonProperty(propertyName="eggGroup", order = 3)]
        public string EggGroup { get; set; }

        public EggGroups()
        {
        }
    }
}
