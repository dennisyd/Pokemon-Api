using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.DamageMultiplier.Models
{
    public class Multiplier
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int? Id{ get; set; }

        [JsonProperty(PropertyName="name", Order = 2)]
        public string Name { get; set; }

        [JsonProperty(PropertyName="normal", Order = 3)]
        public float Normal{ get; set; }

        [JsonProperty(PropertyName="fighting", Order = 4)]
        public float Fighting{ get; set; }

        [JsonProperty(PropertyName="flying", Order = 5)]
        public float Flying{ get; set; }

        [JsonProperty(PropertyName="poison", Order = 6)]
        public float Poison{ get; set; }

        [JsonProperty(PropertyName="ground", Order = 7)]
        public float Ground{ get; set; }

        [JsonProperty(PropertyName="rock", Order = 8)]
        public float Rock{ get; set; }

        [JsonProperty(PropertyName="bug", Order = 9)]
        public float Bug{ get; set; }

        [JsonProperty(PropertyName="ghost", Order = 10)]
        public float Ghost{ get; set; }

        [JsonProperty(PropertyName="steel", Order = 11)]
        public float Steel{ get; set; }

        [JsonProperty(PropertyName="fire", Order = 12)]
        public float Fire{ get; set; }

        [JsonProperty(PropertyName="water", Order = 13)]
        public float Water{ get; set; }

        [JsonProperty(PropertyName="grass", Order = 14)]
        public float Grass{ get; set; }

        [JsonProperty(PropertyName="electric", Order = 15)]
        public float Electric{ get; set; }

        [JsonProperty(PropertyName="psychic", Order = 16)]
        public float Psychic{ get; set; }

        [JsonProperty(PropertyName="ice", Order = 17)]
        public float Ice{ get; set; }

        [JsonProperty(PropertyName="dragon", Order = 18)]
        public float Dragon{ get; set; }

        [JsonProperty(PropertyName="dark", Order = 19)]
        public float Dark{ get; set; }

        [JsonProperty(PropertyName="fairy", Order = 20)]
        public float Fairy{ get; set; }

        public Multiplier()
        {
        }

        public Multiplier(int? Id, string Name, float Normal, float Fighting,
            float Flying, float Poison, float Ground, float Rock, float Bug,
            float Ghost, float Steel, float Fire, float Water, float Grass,
            float Electric, float Psychic, float Ice, float Dragon,
            float Dark, float Fairy)
        {
            this.Id = Id;
            this.Name = Name;
            this.Normal = Normal;
            this.Fighting = Fighting;
            this.Flying = Flying;
            this.Poison = Poison;
            this.Ground = Ground;
            this.Rock = Rock;
            this.Bug = Bug;
            this.Ghost = Ghost;
            this.Steel = Steel;
            this.Fire = Fire;
            this.Water = Water;
            this.Grass = Grass;
            this.Electric = Electric;
            this.Psychic = Psychic;
            this.Ice = Ice;
            this.Dragon = Dragon;
            this.Dark = Dark;
            this.Fairy = Fairy;
        }

        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>()
            {
                {nameof(this.Id).ToLower(), this.Id },
                {nameof(this.Name).ToLower(), this.Name },
                {nameof(this.Normal).ToLower(), this.Normal },
                {nameof(this.Fighting).ToLower(), this.Fighting },
                {nameof(this.Flying).ToLower(), this.Flying },
                {nameof(this.Poison).ToLower(), this.Poison },
                {nameof(this.Ground).ToLower(), this.Ground },
                {nameof(this.Rock).ToLower(), this.Rock },
                {nameof(this.Bug).ToLower(), this.Bug },
                {nameof(this.Ghost).ToLower(), this.Ghost },
                {nameof(this.Steel).ToLower(), this.Steel },
                {nameof(this.Fire).ToLower(), this.Fire },
                {nameof(this.Water).ToLower(), this.Water },
                {nameof(this.Grass).ToLower(), this.Grass },
                {nameof(this.Electric).ToLower(), this.Electric },
                {nameof(this.Psychic).ToLower(), this.Psychic },
                {nameof(this.Ice).ToLower(), this.Ice },
                {nameof(this.Dragon).ToLower(), this.Dragon },
                {nameof(this.Dark).ToLower(), this.Dark },
                {nameof(this.Fairy).ToLower(), this.Fairy }
            };
        }


        public override bool Equals(object obj)
        {
            var item = obj as Multiplier;
            if (item == null)
            {
                return false;
            }

            return
                item.Id.Equals(this.Id) &&
                item.Name.Equals(this.Name) &&
                item.Normal.Equals(this.Normal) &&
                item.Fighting.Equals(this.Fighting) &&
                item.Flying.Equals(this.Flying) &&
                item.Poison.Equals(this.Poison) &&
                item.Ground.Equals(this.Ground) &&
                item.Rock.Equals(this.Rock) &&
                item.Bug.Equals(this.Bug) &&
                item.Ghost.Equals(this.Ghost) &&
                item.Steel.Equals(this.Steel) &&
                item.Fire.Equals(this.Fire) &&
                item.Water.Equals(this.Water) &&
                item.Grass.Equals(this.Grass) &&
                item.Electric.Equals(this.Electric) &&
                item.Psychic.Equals(this.Psychic) &&
                item.Ice.Equals(this.Ice) &&
                item.Dragon.Equals(this.Dragon) &&
                item.Dark.Equals(this.Dark) &&
                item.Fairy.Equals(this.Fairy);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
