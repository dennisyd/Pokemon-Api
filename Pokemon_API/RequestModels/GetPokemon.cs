using System;

using Newtonsoft.JSON;

namespace Pokemon_API.RequestModels
{
    public class GetPokemon
    {
        //[JsonProperty(propertyName = "name", order = 1)]
        public string Name { get; set; }

        //[JsonProperty(propertyName="number", order = 2)]
        public string Number { get; set; }

        //[JsonProperty(propertyName="level", order = 3)]
        public int Level { get; set; }

        public GetPokemon()
        {
        }
    }
}
