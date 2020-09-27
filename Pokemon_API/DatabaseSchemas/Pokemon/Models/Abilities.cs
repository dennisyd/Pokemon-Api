using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Abilities : DatabaseTable<Abilities>
    {
        [JsonIgnore]
        public int? Id { get; set; }

        [JsonProperty(PropertyName="pokemonNumber", Order = 1)]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="ability", Order = 2)]
        public string Ability { get; set; }

        public Abilities()
        {
        }

        public Abilities(int? id, int pokemonNumber, string ability)
        {
            this.Id = id;
            this.PokemonNumber = pokemonNumber;
            this.Ability = ability;
        }
    }
}
