using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Types : DatabaseTable<Types>
    {
        [JsonIgnore]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "pokemonNumber", Order = 1)]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName = "type1", Order = 2)]
        public string Type1 { get; set; }

        [JsonProperty(PropertyName = "type2", Order = 3)]
        public string Type2 { get; set; }

        public Types()
        {
        }

        public Types(int? id, int pokemonNumber, string type1, string type2 = null)
        {
            this.Id = id;
            this.PokemonNumber = pokemonNumber;
            this.Type1 = type1;
            this.Type2 = type2;
        }
    }
}
