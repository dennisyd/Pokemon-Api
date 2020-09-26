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

        public EggGroups(int? Id, int PokemonNumber, string EggGroup)
        {
            this.Id = Id;
            this.PokemonNumber = PokemonNumber;
            this.EggGroup = EggGroup;
        }
    }
}
