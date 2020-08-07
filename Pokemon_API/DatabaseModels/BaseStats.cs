using System;

using Newtonsoft.JSON;

namespace Pokemon_API.DatabaseModels
{
    public class BaseStats
    {
        //[JsonProperty(propertyName="id", order = 1)]
        public int Id { get; set; }

        //[JsonProperty(propertyName="hp", order = 2)]
        public int Hp { get; set; }

        //[JsonProperty(propertyName="attack", order = 3)]
        public int Attack { get; set; }

        //[JsonProperty(propertyName="defense", order = 4)]
        public int Defense { get; set; }

        //[JsonProperty(propertyName="specialAttack", order = 5)]
        public int SpecialAttack { get; set; }

        //[JsonProperty(propertyName="specialDefense", order = 6)]
        public int SpecialDefense { get; set; }

        //[JsonProperty(propertyName="speed", order = 7)]
        public int Speed { get; set; }


        public BaseStats()
        {
        }
    }
}
