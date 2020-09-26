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

        public Moves(int? Id, int PokemonNumber, int MoveNumber, int Level,
            bool IsTM, bool IsHM)
        {
            this.Id = Id;
            this.PokemonNumber = PokemonNumber;
            this.MoveNumber = MoveNumber;
            this.Level = Level;
            this.IsTM = IsTM;
            this.IsHM = IsHM;
        }
    }
}
