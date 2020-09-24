using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Moves.Models
{
    public class Moves
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

        [JsonProperty(PropertyName = "flags", Order = 11)]
        public List<string> Flags { get; set; }

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
            int Priority, int CritRatio, string Target, string ContestType)
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
            this.ContestType = ContestType;
        }

        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>()
            {
                {nameof(this.Id).ToLower(), this.Id },
                {nameof(this.Name).ToLower(), this.Name },
                {nameof(this.Number).ToLower(), this.Number },
                {nameof(this.Accuracy).ToLower(), this.Accuracy },
                {nameof(this.BasePower).ToLower(), this.BasePower },
                {nameof(this.Category).ToLower(), this.Category },
                {nameof(this.Description).ToLower(), this.Description },
                {nameof(this.ShortDescription).ToLower(), this.ShortDescription },
                {nameof(this.PP).ToLower(), this.PP },
                {nameof(this.Priority).ToLower(), this.Priority },
                {nameof(this.CritRatio).ToLower(), this.CritRatio },
                {nameof(this.Target).ToLower(), this.Target },
                {nameof(this.ContestType).ToLower(), this.ContestType },
            };
        }

        public override bool Equals(object obj)
        {
            var item = obj as Moves;
            if (item == null)
            {
                return false;
            }

            return
                item.Id.Equals(this.Id) &&
                item.Name.Equals(this.Name) &&
                item.Number.Equals(this.Number) &&
                item.Accuracy.Equals(this.Accuracy) &&
                item.BasePower.Equals(this.BasePower) &&
                item.Category.Equals(this.Category) &&
                item.Description.Equals(this.Description) &&
                item.ShortDescription.Equals(this.ShortDescription) &&
                item.PP.Equals(this.PP) &&
                item.Priority.Equals(this.Priority) &&
                item.CritRatio.Equals(this.CritRatio) &&
                item.Target.Equals(this.Target) &&
                item.ContestType.Equals(this.ContestType);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
