using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.DamageMultiplier.Models
{
    public class Multiplier : DatabaseTable<Multiplier>
    {
        [JsonIgnore]
        public int? Id{ get; set; }

        [JsonProperty(PropertyName="name", Order = 1)]
        public string Name { get; set; }

        [JsonProperty(PropertyName="normal", Order = 2)]
        public float Normal{ get; set; }

        [JsonProperty(PropertyName="fighting", Order = 3)]
        public float Fighting{ get; set; }

        [JsonProperty(PropertyName="flying", Order = 4)]
        public float Flying{ get; set; }

        [JsonProperty(PropertyName="poison", Order = 5)]
        public float Poison{ get; set; }

        [JsonProperty(PropertyName="ground", Order = 6)]
        public float Ground{ get; set; }

        [JsonProperty(PropertyName="rock", Order = 7)]
        public float Rock{ get; set; }

        [JsonProperty(PropertyName="bug", Order = 8)]
        public float Bug{ get; set; }

        [JsonProperty(PropertyName="ghost", Order = 9)]
        public float Ghost{ get; set; }

        [JsonProperty(PropertyName="steel", Order = 10)]
        public float Steel{ get; set; }

        [JsonProperty(PropertyName="fire", Order = 11)]
        public float Fire{ get; set; }

        [JsonProperty(PropertyName="water", Order = 12)]
        public float Water{ get; set; }

        [JsonProperty(PropertyName="grass", Order = 13)]
        public float Grass{ get; set; }

        [JsonProperty(PropertyName="electric", Order = 14)]
        public float Electric{ get; set; }

        [JsonProperty(PropertyName="psychic", Order = 15)]
        public float Psychic{ get; set; }

        [JsonProperty(PropertyName="ice", Order = 16)]
        public float Ice{ get; set; }

        [JsonProperty(PropertyName="dragon", Order = 17)]
        public float Dragon{ get; set; }

        [JsonProperty(PropertyName="dark", Order = 18)]
        public float Dark{ get; set; }

        [JsonProperty(PropertyName="fairy", Order = 19)]
        public float Fairy{ get; set; }

        public Multiplier()
        {
        }

        public Multiplier(int? id, string name, float normal, float fighting,
            float flying, float poison, float ground, float rock, float bug,
            float ghost, float steel, float fire, float water, float grass,
            float electric, float psychic, float ice, float dragon,
            float dark, float fairy)
        {
            this.Id = id;
            this.Name = name;
            this.Normal = normal;
            this.Fighting = fighting;
            this.Flying = flying;
            this.Poison = poison;
            this.Ground = ground;
            this.Rock = rock;
            this.Bug = bug;
            this.Ghost = ghost;
            this.Steel = steel;
            this.Fire = fire;
            this.Water = water;
            this.Grass = grass;
            this.Electric = electric;
            this.Psychic = psychic;
            this.Ice = ice;
            this.Dragon = dragon;
            this.Dark = dark;
            this.Fairy = fairy;
        }
    }
}
