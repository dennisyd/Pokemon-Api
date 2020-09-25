using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Moves
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

        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>()
            {
                {nameof(this.Id).ToLower(), this.Id },
                {nameof(this.PokemonNumber).ToLower(), this.PokemonNumber },
                {nameof(this.MoveNumber).ToLower(), this.MoveNumber },
                {nameof(this.Level).ToLower(), this.Level },
                {nameof(this.IsTM).ToLower(), this.IsTM },
                {nameof(this.IsHM).ToLower(), this.IsHM }
            };
        }

        public override bool Equals(object obj)
        {
            var item = obj as Moves;
            if (item == null)
            {
                return false;
            }

            return
                item.Id.Equals(this.Id) &&
                item.PokemonNumber.Equals(this.PokemonNumber) &&
                item.MoveNumber.Equals(this.MoveNumber) &&
                item.Level.Equals(this.Level) &&
                item.IsTM.Equals(this.IsTM) &&
                item.IsHM.Equals(this.IsHM);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
