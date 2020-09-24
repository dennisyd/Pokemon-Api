using System.Collections.Generic;

using Newtonsoft.Json;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class BaseStats
    {
        [JsonProperty(PropertyName="id", Order = 1)]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "pokemonNumber", Order = 2)]
        public int PokemonNumber { get; set; }

        [JsonProperty(PropertyName="hp", Order = 3)]
        public int Hp { get; set; }

        [JsonProperty(PropertyName="attack", Order = 4)]
        public int Attack { get; set; }

        [JsonProperty(PropertyName="defense", Order = 5)]
        public int Defense { get; set; }

        [JsonProperty(PropertyName="specialAttack", Order = 6)]
        public int SpecialAttack { get; set; }

        [JsonProperty(PropertyName="specialDefense", Order = 7)]
        public int SpecialDefense { get; set; }

        [JsonProperty(PropertyName="speed", Order = 8)]
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

        public Dictionary<string, object> ToDict()
        {
            return new Dictionary<string, object>()
            {
                {nameof(this.Id).ToLower(), this.Id },
                {nameof(this.PokemonNumber).ToLower(), this.PokemonNumber },
                {nameof(this.Hp).ToLower(), this.Hp },
                {nameof(this.Attack).ToLower(), this.Attack },
                {nameof(this.Defense).ToLower(), this.Defense },
                {nameof(this.SpecialAttack).ToLower(), this.SpecialAttack },
                {nameof(this.SpecialDefense).ToLower(), this.SpecialDefense },
                {nameof(this.Speed).ToLower(), this.Speed }
            };
        }

        public override bool Equals(object obj)
        {
            var item = obj as BaseStats;
            if (item == null)
            {
                return false;
            }

            return
                item.Id.Equals(this.Id) &&
                item.PokemonNumber.Equals(this.PokemonNumber) &&
                item.Hp.Equals(this.Hp) &&
                item.Attack.Equals(this.Attack) &&
                item.Defense.Equals(this.Defense) &&
                item.SpecialAttack.Equals(this.SpecialAttack) &&
                item.SpecialDefense.Equals(this.SpecialDefense) &&
                item.Speed.Equals(this.Speed);

        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
