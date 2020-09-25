using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Pokemon
    {
        [JsonIgnore]
        public int? Id { get; set; }

        [JsonProperty(PropertyName="name", Order = 1)]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "number", Order = 2)]
        public int Number { get; set; }

        [JsonProperty(PropertyName = "species", Order = 3)]
        public string Species { get; set; }

        [JsonProperty(PropertyName = "height", Order = 4)]
        public float Height { get; set; }

        [JsonProperty(PropertyName = "weight", Order = 5)]
        public float Weight { get; set; }

        [JsonProperty(PropertyName = "color", Order = 6)]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "evolutionLevel", Order = 7)]
        public int? EvolutionLevel { get; set; }

        public Pokemon()
        {
        }

        public Pokemon(int? Id, string Name, int Number, string Species, float Height, float Weight, string Color, int? EvolutionLevel)
        {
            this.Id = Id;
            this.Name = Name;
            this.Number = Number;
            this.Species = Species;
            this.Height = Height;
            this.Weight = Weight;
            this.Color = Color;
            this.EvolutionLevel = EvolutionLevel;
        }

        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>()
            {
                {nameof(this.Id).ToLower(), this.Id },
                {nameof(this.Name).ToLower(), this.Name },
                {nameof(this.Number).ToLower(), this.Number },
                {nameof(this.Species).ToLower(), this.Species },
                {nameof(this.Height).ToLower(), this.Height },
                {nameof(this.Weight).ToLower(), this.Weight },
                {nameof(this.Color).ToLower(), this.Color },
                {nameof(this.EvolutionLevel).ToLower(), this.EvolutionLevel },
            };
        }

        public override bool Equals(object obj)
        {
            var item = obj as Pokemon;
            if (item == null)
            {
                return false;
            }

            return
                item.Id.Equals(this.Id) &&
                item.Name.Equals(this.Name) &&
                item.Number.Equals(this.Number) &&
                item.Species.Equals(this.Species) &&
                item.Height.Equals(this.Height) &&
                item.Weight.Equals(this.Weight) &&
                item.Color.Equals(this.Color) &&
                item.EvolutionLevel.Equals(this.EvolutionLevel);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
