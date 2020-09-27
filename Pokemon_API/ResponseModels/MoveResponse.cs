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

        public MoveResponse(string Name, int Number, int Accuracy, int BasePower,
            string Category, string Description, string ShortDescription, int PP,
            int Priority, int CritRatio, List<string> Flags, string Target, string Type, string ContestType)
        {
            this.Name = Name;
            this.Number = Number;
            this.Accuracy = Accuracy;
            this.BasePower = BasePower;
            this.Category = Category;
            this.Description = Description;
            this.ShortDescription = ShortDescription;
            this.PP = PP;
            this.Priority = Priority;
            this.CritRatio = CritRatio;
            this.Flags = Flags;
            this.Target = Target;
            this.Type = Type;
            this.ContestType = ContestType;
        }
    }
}
