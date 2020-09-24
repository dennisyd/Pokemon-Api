using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Moves.Models
{
    public class Flags
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int? Id { get; set; }

        [JsonProperty(PropertyName="moveNumber", Order = 2)]
        public int MoveNumber { get; set; }

        [JsonProperty(PropertyName="flag", Order = 3)]
        public string Flag { get; set; }

        public Flags()
        {
        }

        public Flags(int? Id, int MoveNumber, string Flag)
        {
            this.Id = Id;
            this.MoveNumber = MoveNumber;
            this.Flag = Flag;
        }

        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>()
            {
                {nameof(this.Id).ToLower(), this.Id },
                {nameof(this.MoveNumber).ToLower(), this.MoveNumber },
                {nameof(this.Flag).ToLower(), this.Flag }
            };
        }

        public override bool Equals(object obj)
        {
            var item = obj as Flags;
            if (item == null)
            {
                return false;
            }

            return
                item.Id.Equals(this.Id) &&
                item.MoveNumber.Equals(this.MoveNumber) &&
                item.Flag.Equals(this.Flag);
        }


        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
