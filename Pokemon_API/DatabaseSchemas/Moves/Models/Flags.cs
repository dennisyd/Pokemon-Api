using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Moves.Models
{
    public class Flags : DatabaseTable<Flags>
    {
        [JsonIgnore]
        public int? Id { get; set; }

        [JsonIgnore]
        public int MoveNumber { get; set; }

        [JsonProperty(PropertyName="flag", Order = 1)]
        public string Flag { get; set; }

        public Flags()
        {
        }

        public Flags(int? id, int moveNumber, string flag)
        {
            this.Id = id;
            this.MoveNumber = moveNumber;
            this.Flag = flag;
        }
    }
}
