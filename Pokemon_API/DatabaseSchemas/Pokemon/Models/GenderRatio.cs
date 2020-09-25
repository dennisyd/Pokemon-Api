using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class GenderRatio
    {
        [JsonIgnore]
        public int? Id { get; set; }

        [JsonIgnore]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="male", Order = 1)]
        public float Male { get; set; }

        [JsonProperty(PropertyName="female", Order = 2)]
        public float Female { get; set; }

        public GenderRatio()
        {
        }

        public GenderRatio(int? Id, int PokemonNumber, float Male, float Female)
        {
            this.Id = Id;
            this.PokemonNumber = PokemonNumber;
            this.Male = Male;
            this.Female = Female;
        }

        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>()
            {
                {nameof(this.Id).ToLower(), this.Id },
                {nameof(this.PokemonNumber).ToLower(), this.PokemonNumber },
                {nameof(this.Male).ToLower(), this.Male },
                {nameof(this.Female).ToLower(), this.Female }
            };
        }

        public override bool Equals(object obj)
        {
            var item = obj as GenderRatio;
            if (item == null)
            {
                return false;
            }

            return
                item.Id.Equals(this.Id) &&
                item.PokemonNumber.Equals(this.PokemonNumber) &&
                item.Male.Equals(this.Male) &&
                item.Female.Equals(this.Female);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
