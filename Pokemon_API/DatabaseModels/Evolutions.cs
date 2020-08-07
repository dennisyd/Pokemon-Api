using System;

using Newtonsoft.JSON;

namespace Pokemon_API.DatabaseModels
{
    public class Evolutions
    {
        //[JsonProperty(propertyName="id", order = 1)]
        public int Id { get; set; }

        //[JsonProperty(propertyName="pokemonNumber", order = 2)]
        public int PokemonNumber { get; set; }

        //[JsonProperty(propertyName="evolution", order = 3)]
        public string Evolution { get; set; }

        public Evolutions()
        {
        }
    }
}
