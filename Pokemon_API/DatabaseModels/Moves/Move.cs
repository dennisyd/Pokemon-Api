using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseModels.Moves
{
    public class Moves
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name", Order = 2)]
        public string Name { get; set; }

        [JsonProperty(PropertyName="number", Order = 3)]
        public string Number { get; set; }

        [JsonProperty(PropertyName="accuracy", Order = 4)]
        public string Accuracy { get; set; }

        [JsonProperty(PropertyName = "basePower", Order = 5)]
        public string BasePower { get; set; }

        [JsonProperty(PropertyName = "category", Order = 6)]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "description", Order = 7)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "shortDescription", Order = 8)]
        public string ShortDescription { get; set; }

        [JsonProperty(PropertyName = "pp", Order = 9)]
        public int PP { get; set; }

        [JsonProperty(PropertyName = "priority", Order = 10)]
        public int Priority { get; set; }

        [JsonProperty(PropertyName = "flags", Order = 11)]
        public List<string> Flags { get; set; }

        [JsonProperty(PropertyName = "critRatio", Order = 12)]
        public int CriticalRatio { get; set; }

        [JsonProperty(PropertyName = "target", Order = 13)]
        public string Target { get; set; }

        [JsonProperty(PropertyName = "type", Order = 14)]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "contestType", Order = 15)]
        public string ContestType { get; set; }

        public Moves()
        {
        }
    }
}
