using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class EggGroups : DatabaseTable<EggGroups>
    {
        [JsonIgnore]
        public int? Id { get; set; }

        [JsonIgnore]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="eggGroup", Order = 1)]
        public string EggGroup { get; set; }

        public EggGroups()
        {
        }

        public EggGroups(int? id, int pokemonNumber, string eggGroup)
        {
            this.Id = id;
            this.PokemonNumber = pokemonNumber;
            this.EggGroup = eggGroup;
        }
    }
}
