using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class BaseStats : DatabaseTable<BaseStats>
    {
        [JsonIgnore]
        public int? Id { get; set; }

        [JsonIgnore]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="hp", Order = 1)]
        public int Hp { get; set; }

        [JsonProperty(PropertyName="attack", Order = 2)]
        public int Attack { get; set; }

        [JsonProperty(PropertyName="defense", Order = 3)]
        public int Defense { get; set; }

        [JsonProperty(PropertyName="specialAttack", Order = 4)]
        public int SpecialAttack { get; set; }

        [JsonProperty(PropertyName="specialDefense", Order = 5)]
        public int SpecialDefense { get; set; }

        [JsonProperty(PropertyName="speed", Order = 6)]
        public int Speed { get; set; }


        public BaseStats()
        {
        }

        public BaseStats(int? Id, int PokemonNumber, int Hp, int Attack, int Defense,
            int SpecialAttack, int SpecialDefense, int Speed)
        {
            this.Id = Id;
            this.PokemonNumber = PokemonNumber;
            this.Hp = Hp;
            this.Attack = Attack;
            this.Defense = Defense;
            this.SpecialAttack = SpecialAttack;
            this.SpecialDefense = SpecialDefense;
            this.Speed = Speed;
        }
    }
}
