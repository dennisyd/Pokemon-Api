using System;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Moves
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int Id { get; set; }

        [JsonProperty(PropertyName="pokemonNumber", Order = 2)]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="moveNumber", Order = 3)]
        public int MoveNumber { get; set; }

        [JsonProperty(PropertyName="level", Order = 4)]
        public int Level { get; set; }

        [JsonProperty(PropertyName="isTM", Order = 5)]
        public bool IsTM { get; set; }

        [JsonProperty(PropertyName="isHM", Order = 6)]
        public bool IsHM { get; set; }

        public Moves()
        {
        }
    }
}
