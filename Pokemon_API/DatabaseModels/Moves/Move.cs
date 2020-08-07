using System;

using Newtonsoft.JSON;

namespace Pokemon_API.DatabaseModels.Moves
{
    public class Moves
    {
        //[JsonProperty(propertyName="id", order = 1)]
        public string Id { get; set; }

        //[JsonProperty(propertyName = "name", order = 2)]
        public string Name { get; set; }

        //[JsonProperty(propertyName="number", order = 3)]
        public string Number { get; set; }

        //[JsonProperty(propertyName="accuracy", order = 4)]
        public string Accuracy { get; set; }

        //[JsonProperty(propertyName = "basePower", order = 5)]
        public string BasePower { get; set; }

        //[JsonProperty(propertyName = "category", order = 6)]
        public string Category { get; set; }

        //[JsonProperty(propertyName = "description", order = 7)]
        public string Description { get; set; }

        //[JsonProperty(propertyName = "shortDescription", order = 8)]
        public string ShortDescription { get; set; }

        //[JsonProperty(propertyName = "PP", order = 9)]
        public int PP { get; set; }

        //[JsonProperty(propertyName = "priority", order = 10)]
        public int Priority { get; set; }

        //[JsonProperty(propertyName = "flags", order = 11)]
        public List<string> Flags { get; set; }

        //[JsonProperty(propertyName = "critRatio", order = 12)]
        public int CriticalRatio { get; set; }

        //[JsonProperty(propertyName = "target", order = 13)]
        public string Target { get; set; }

        //[JsonProperty(propertyName = "type", order = 14)]
        public string Type { get; set; }

        //[JsonProperty(propertyName = "contestType", order = 15)]
        public string ContestType { get; set; }

        public Moves()
        {
        }
    }
}
