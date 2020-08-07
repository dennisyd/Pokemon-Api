using System;

using Newtonsoft.JSON;

namespace Pokemon_API.DatabaseModels.Pokemon
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

        //[JsonProperty(propertyName="isTM", order = 5)]
        public bool IsTM { get; set; }

        //[JsonProperty(propertyName="isHM", order = 6)]
        public bool IsHM { get; set; }

        public Moves()
        {
        }
    }
}
