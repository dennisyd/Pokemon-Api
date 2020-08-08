using System;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseModels.Moves
{
    public class Flags
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int Id { get; set; }

        [JsonProperty(PropertyName="moveId", Order = 2)]
        public int MoveId { get; set; }

        [JsonProperty(PropertyName="flag", Order = 3)]
        public string Flag { get; set; }

        public Flags()
        {
        }
    }
}
