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

        public Moves(int? Id, string Name, int Number, int Accuracy, int BasePower,
            string Category, string Description, string ShortDescription, int PP,
            int Priority, int CritRatio, string Target, string Type, string ContestType)
        {
            this.Id = Id;
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
            this.Target = Target;
            this.Type = Type;
            this.ContestType = ContestType;
        }
    }
}
