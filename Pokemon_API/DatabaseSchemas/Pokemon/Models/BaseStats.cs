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

        public BaseStats(int? id, int pokemonNumber, int hp, int attack, int defense,
            int specialAttack, int specialDefense, int speed)
        {
            this.Id = id;
            this.PokemonNumber = pokemonNumber;
            this.Hp = hp;
            this.Attack = attack;
            this.Defense = defense;
            this.SpecialAttack = specialAttack;
            this.SpecialDefense = specialDefense;
            this.Speed = speed;
        }
    }
}
