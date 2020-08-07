using System;

using Newtonsoft.JSON;

namespace Pokemon_API.DatabaseModels.Moves
{
    public class Flags
    {
        //[JsonProperty(propertyName="id", order = 1)]
        public int Id { get; set; }

        //[JsonProperty(propertyName="moveId", order = 2)]
        public int MoveId { get; set; }

        //[JsonProperty(propertyName="flag", order = 3)]
        public string Flag { get; set; }

        public Flags()
        {
        }
    }
}
