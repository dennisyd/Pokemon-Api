using System.Collections.Generic;

using Newtonsoft.Json;

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

        public MoveResponse(string name, int number, int accuracy, int basePower,
            string category, string description, string shortDescription, int pp,
            int priority, int critRatio, List<string> flags, string target, string type,
            string contestType)
        {
            this.Name = name;
            this.Number = number;
            this.Accuracy = accuracy;
            this.BasePower = basePower;
            this.Category = category;
            this.Description = description;
            this.ShortDescription = shortDescription;
            this.PP = pp;
            this.Priority = priority;
            this.CritRatio = critRatio;
            this.Flags = flags;
            this.Target = target;
            this.Type = type;
            this.ContestType = contestType;
        }
    }
}
