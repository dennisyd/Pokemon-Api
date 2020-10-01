using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Pokemon : DatabaseTable<Pokemon>
    {
        public int? Id { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public float Height_M { get; set; }

        public float Weight_Kg { get; set; }

        public string Color { get; set; }

        public string Gender { get; set; }

        public bool? CanHatch { get; set; }

        public string Prevo { get; set; }

        public int? EvoLevel { get; set; }

        public string EvoType { get; set; }

        public string EvoItem { get; set; }

        public string EvoCondition { get; set; }

        public Pokemon()
        {
        }

        public Pokemon(int? id, int number, string name, float height_m,
            float weight_kg, string color, string gender = default(string),
            bool? canHatch = null, string prevo = default(string),
            int? evoLevel = null, string evoType = default(string),
            string evoItem = default(string), string
            evoCondition = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.Height_M = height_m;
            this.Weight_Kg = weight_kg;
            this.Color = color;
            this.Gender = gender;
            this.CanHatch = canHatch;
            this.Prevo = prevo;
            this.EvoLevel = evoLevel;
            this.EvoType = evoType;
            this.EvoItem = evoItem;
            this.EvoCondition = evoCondition;
        }
    }
}
