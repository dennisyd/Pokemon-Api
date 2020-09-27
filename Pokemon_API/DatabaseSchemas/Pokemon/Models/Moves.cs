using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Moves : DatabaseTable<Moves>
    {
        [JsonIgnore]
        public int? Id { get; set; }

        [JsonIgnore]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="moveNumber", Order = 1)]
        public int MoveNumber { get; set; }

        [JsonProperty(PropertyName="level", Order = 2)]
        public int Level { get; set; }

        [JsonProperty(PropertyName="isTM", Order = 3, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTM { get; set; }

        [JsonProperty(PropertyName="isHM", Order = 4, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHM { get; set; }

        public Moves()
        {
        }

        public Moves(int? id, int pokemonNumber, int moveNumber, int level,
            bool isTM, bool isHM)
        {
            this.Id = id;
            this.PokemonNumber = pokemonNumber;
            this.MoveNumber = moveNumber;
            this.Level = level;
            this.IsTM = isTM;
            this.IsHM = isHM;
        }
    }
}
