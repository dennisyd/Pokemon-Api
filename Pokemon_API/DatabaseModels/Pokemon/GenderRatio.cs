using System;

using NewtonSoft.JSON;

namespace Pokemon_API.DatabaseModels.Pokemon
{
    public class GenderRatio
    {
        //[JsonProperty(propertyName="id", order = 1)]
        public string Id { get; set; }

        //[JsonProperty(propertyName="male", order = 2)]
        public float Male { get; set; }

        //[JsonProperty(propertyName="female", order = 3)]
        public float Female { get; set; }

        public GenderRatio()
        {
        }
    }
}
