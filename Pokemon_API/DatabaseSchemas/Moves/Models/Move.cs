using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Moves.Models
{
    public class Moves : DatabaseTable<Moves>
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "name", Order = 2)]
        public string Name { get; set; }

        [JsonProperty(PropertyName="number", Order = 3)]
        public int Number { get; set; }

        [JsonProperty(PropertyName="accuracy", Order = 4)]
        public int Accuracy { get; set; }

        [JsonProperty(PropertyName = "basePower", Order = 5)]
        public int BasePower { get; set; }

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

        [JsonProperty(PropertyName = "critRatio", Order = 12)]
        public int CritRatio { get; set; }

        [JsonProperty(PropertyName = "target", Order = 13)]
        public string Target { get; set; }

        [JsonProperty(PropertyName = "type", Order = 14)]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "contestType", Order = 15)]
        public string ContestType { get; set; }

        public Moves()
        {
        }

        public Moves(int? id, string name, int number, int accuracy, int basePower,
            string category, string description, string shortDescription, int pp,
            int priority, int critRatio, string target, string type, string contestType)
        {
            this.Id = id;
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
            this.Target = target;
            this.Type = type;
            this.ContestType = contestType;
        }
    }
}
