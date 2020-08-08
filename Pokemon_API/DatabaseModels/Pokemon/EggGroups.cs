using System;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseModels.Pokemon
{
    public class EggGroups
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int Id { get; set; }

        [JsonProperty(PropertyName="pokemonNumber", Order = 2)]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="eggGroup", Order = 3)]
        public string EggGroup { get; set; }

        public EggGroups()
        {
        }
    }
}
