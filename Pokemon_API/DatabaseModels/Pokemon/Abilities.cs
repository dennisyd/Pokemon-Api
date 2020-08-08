using System;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseModels.Pokemon
{
    public class Abilities
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int Id { get; set; }

        [JsonProperty(PropertyName="pokemonNumber", Order = 2)]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="ability", Order = 3)]
        public string Ability { get; set; }

        public Abilities()
        {
        }
    }
}
