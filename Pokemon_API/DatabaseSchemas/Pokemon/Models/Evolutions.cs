using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Evolutions : DatabaseTable<Evolutions>
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
    }
}
