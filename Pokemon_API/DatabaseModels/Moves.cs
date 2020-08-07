using System;

using Newtonsoft.JSON;

namespace Pokemon_API.DatabaseModels
{
    public class Moves
    {
        //[JsonProperty(propertyName="id", order = 1)]
        public int Id { get; set; }

        //[JsonProperty(propertyName="pokemonNumber", order = 2)]
        public int PokemonNumber { get; set; }

        //[JsonProperty(propertyName="moveNumber", order = 3)]
        public int MoveNumber { get; set; }

        //[JsonProperty(propertyName="level", order = 4)]
        public int Level { get; set; }

        public Moves()
        {
        }
    }
}
