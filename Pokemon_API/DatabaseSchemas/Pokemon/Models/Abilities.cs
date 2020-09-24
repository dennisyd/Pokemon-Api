using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Abilities
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int? Id { get; set; }

        [JsonProperty(PropertyName="pokemonNumber", Order = 2)]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="ability", Order = 3)]
        public string Ability { get; set; }

        public Abilities()
        {
        }

        public Abilities(int? Id, int PokemonNumber, string Ability)
        {
            this.Id = Id;
            this.PokemonNumber = PokemonNumber;
            this.Ability = Ability;
        }

        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>()
            {
                {nameof(this.Id).ToLower(), this.Id },
                {nameof(this.PokemonNumber).ToLower(), this.PokemonNumber },
                {nameof(this.Ability).ToLower(), this.Ability }
            };
        }

        public override bool Equals(object obj)
        {
            var item = obj as Abilities;
            if (item == null)
            {
                return false;
            }

            return
                item.Id.Equals(this.Id) &&
                item.PokemonNumber.Equals(this.PokemonNumber) &&
                item.Ability.Equals(this.Ability);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
