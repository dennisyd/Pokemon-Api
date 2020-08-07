using System;

using Newtonsoft.JSON;

namespace Pokemon_API.DatabaseModels.DamageMultiplier
{
    public class DamageMultiplier
    {
        //[JsonProperty(propertyName="id", order = 1)]
        public int Id{ get; set; }

        //[JsonProperty(propertyName="name", order = 2)]
        public int Name { get; set; }

        //[JsonProperty(propertyName="normal", order = 3)]
        public float Normal{ get; set; }

        //[JsonProperty(propertyName="fighting", order = 4)]
        public float Fighting{ get; set; }

        //[JsonProperty(propertyName="flying", order = 5)]
        public float Flying{ get; set; }

        //[JsonProperty(propertyName="poison", order = 6)]
        public float Poison{ get; set; }

        //[JsonProperty(propertyName="ground", order = 7)]
        public float Ground{ get; set; }

        //[JsonProperty(propertyName="rock", order = 8)]
        public float Rock{ get; set; }

        //[JsonProperty(propertyName="bug", order = 9)]
        public float Bug{ get; set; }

        //[JsonProperty(propertyName="ghost", order = 10)]
        public float Ghost{ get; set; }

        //[JsonProperty(propertyName="steel", order = 11)]
        public float Steel{ get; set; }

        //[JsonProperty(propertyName="fire", order = 12)]
        public float Fire{ get; set; }

        //[JsonProperty(propertyName="water", order = 13)]
        public float Water{ get; set; }

        //[JsonProperty(propertyName="grass", order = 14)]
        public float Grass{ get; set; }

        //[JsonProperty(propertyName="electric", order = 15)]
        public float Electric{ get; set; }

        //[JsonProperty(propertyName="psychic", order = 16)]
        public float Psychic{ get; set; }

        //[JsonProperty(propertyName="ice", order = 17)]
        public float Ice{ get; set; }

        //[JsonProperty(propertyName="dragon", order = 18)]
        public float Dragon{ get; set; }

        //[JsonProperty(propertyName="dark", order = 19)]
        public float Dark{ get; set; }

        //[JsonProperty(propertyName="fairy", order = 20)]
        public float Fairy{ get; set; }

        public DamageMultiplier()
        {
        }
    }
}
