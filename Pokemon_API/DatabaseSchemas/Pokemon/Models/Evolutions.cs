using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Evolutions
    {
        [JsonIgnore]
        public int? Id { get; set; }

        [JsonIgnore]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="evolution", Order = 1)]
        public string Evolution { get; set; }

        public Evolutions()
        {
        }

        public Evolutions(int? Id, int PokemonNumber, string Evolution)
        {
            this.Id = Id;
            this.PokemonNumber = PokemonNumber;
            this.Evolution = Evolution;
        }

        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>()
            {
                {nameof(this.Id).ToLower(), this.Id },
                {nameof(this.PokemonNumber).ToLower(), this.PokemonNumber },
                {nameof(this.Evolution).ToLower(), this.Evolution }
            };
        }

        public override bool Equals(object obj)
        {
            var item = obj as Evolutions;
            if (item == null)
            {
                return false;
            }

            return
                item.Id.Equals(this.Id) &&
                item.PokemonNumber.Equals(this.PokemonNumber) &&
                item.Evolution.Equals(this.Evolution);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
