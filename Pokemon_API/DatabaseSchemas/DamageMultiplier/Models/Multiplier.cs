using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.DamageMultiplier.Models
{
    public class Multiplier : DatabaseTable<Multiplier>
    {
        public int? Id{ get; set; }

        public string Name { get; set; }

        public float Normal{ get; set; }

        public float Fighting{ get; set; }

        public float Flying{ get; set; }

        public float Poison{ get; set; }

        public float Ground{ get; set; }

        public float Rock{ get; set; }

        public float Bug{ get; set; }

        public float Ghost{ get; set; }

        public float Steel{ get; set; }

        public float Fire{ get; set; }

        public float Water{ get; set; }

        public float Grass{ get; set; }

        public float Electric{ get; set; }

        public float Psychic{ get; set; }

        public float Ice{ get; set; }

        public float Dragon{ get; set; }

        public float Dark{ get; set; }

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
