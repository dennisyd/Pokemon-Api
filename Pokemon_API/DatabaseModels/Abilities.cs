using System;
namespace Pokemon_API.DatabaseModels
{
    public class Abilities
    {
        //[JsonProperty(propertyName="id", order = 1)]
        public int Id { get; set; }

        //[JsonProperty(propertyName="pokemonNumber", order = 2)]
        public int PokemonNumber { get; set; }

        //[JsonProperty(propertyName="ability", order = 3)]
        public string Ability { get; set; }

        public Abilities()
        {
        }
    }
}
