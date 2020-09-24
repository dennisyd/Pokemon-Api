using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class EggGroups
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int? Id { get; set; }

        [JsonProperty(PropertyName="pokemonNumber", Order = 2)]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="eggGroup", Order = 3)]
        public string EggGroup { get; set; }

        public EggGroups()
        {
        }

        public EggGroups(int? Id, int PokemonNumber, string EggGroup)
        {
            this.Id = Id;
            this.PokemonNumber = PokemonNumber;
            this.EggGroup = EggGroup;
        }

        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>()
            {
                {nameof(this.Id).ToLower(), this.Id },
                {nameof(this.PokemonNumber).ToLower(), this.PokemonNumber },
                {nameof(this.EggGroup).ToLower(), this.EggGroup }
            };
        }

        public override bool Equals(object obj)
        {
            var item = obj as EggGroups;
            if (item == null)
            {
                return false;
            }

            return
                item.Id.Equals(this.Id) &&
                item.PokemonNumber.Equals(this.PokemonNumber) &&
                item.EggGroup.Equals(this.EggGroup);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
