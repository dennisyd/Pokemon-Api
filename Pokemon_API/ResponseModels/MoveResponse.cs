using System.Collections.Generic;

using Newtonsoft.Json;

using Pokemon_API.DatabaseSchemas.Moves.Models;

namespace Pokemon_API.ResponseModels
{
    public class MoveResponse
    {
        [JsonProperty(PropertyName = "name", Order = 1)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "number", Order = 2)]
        public int Number { get; set; }

        [JsonProperty(PropertyName = "accuracy", Order = 3)]
        public int Accuracy { get; set; }

        [JsonProperty(PropertyName = "basePower", Order = 4)]
        public int BasePower { get; set; }

        [JsonProperty(PropertyName = "category", Order = 5)]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "description", Order = 6)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "shortDescription", Order = 7)]
        public string ShortDescription { get; set; }

        [JsonProperty(PropertyName = "pp", Order = 8)]
        public int PP { get; set; }

        [JsonProperty(PropertyName = "priority", Order = 9)]
        public int Priority { get; set; }

        [JsonProperty(PropertyName = "critRatio", Order = 11)]
        public int CritRatio { get; set; }

        [JsonProperty(PropertyName ="flags", Order = 12)]
        public List<string> Flags { get; set; }

        [JsonProperty(PropertyName = "target", Order = 13)]
        public string Target { get; set; }

        [JsonProperty(PropertyName = "type", Order = 14)]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "contestType", Order = 15)]
        public string ContestType { get; set; }

        public MoveResponse()
        {
        }

        public MoveResponse(Moves move, List<string> flags)
        {
            this.Name = move.Name;
            this.Number = move.Number;
            this.Accuracy = move.Accuracy;
            this.BasePower = move.BasePower;
            this.Category = move.Category;
            this.Description = move.Description;
            this.ShortDescription = move.ShortDescription;
            this.PP = move.PP;
            this.Priority = move.Priority;
            this.CritRatio = move.CritRatio;
            this.Flags = (flags.Count != 0) ? flags : null;
            this.Target = move.Target;
            this.Type = move.Type;
            this.ContestType = move.ContestType;
        }
    }
}
