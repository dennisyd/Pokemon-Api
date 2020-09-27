using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Pokemon : DatabaseTable<Pokemon>
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

        public Pokemon(int? id, string name, int number, string species,
            float height, float weight, string color, int? evolutionLevel)
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.Species = species;
            this.Height = height;
            this.Weight = weight;
            this.Color = color;
            this.EvolutionLevel = evolutionLevel;
        }
    }
}
