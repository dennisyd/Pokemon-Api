using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Moves.Models
{
    public class Moves : DatabaseTable<Moves>
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public int Accuracy { get; set; }

        public int BasePower { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string ShortDesc { get; set; }

        public int PP { get; set; }

        public int Priority { get; set; }

        public int CritRatio { get; set; }

        public string Target { get; set; }

        public string Type { get; set; }

        public string ContestType { get; set; }

        public Moves()
        {
        }

        public Moves(int? id, string name, int number, int accuracy, int basePower,
            string category, string description, string shortDesc, int pp,
            int priority, int critRatio, string target, string type, string contestType)
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.Accuracy = accuracy;
            this.BasePower = basePower;
            this.Category = category;
            this.Description = description;
            this.ShortDesc = shortDesc;
            this.PP = pp;
            this.Priority = priority;
            this.CritRatio = critRatio;
            this.Target = target;
            this.Type = type;
            this.ContestType = contestType;
        }
    }
}
