using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Abilities : DatabaseTable<Abilities>
    {

        public int? Id { get; set; }

        public int PokemonNumber { get; set; }

        public string Ability1 { get; set; }

        public string Ability2 { get; set; }

        public string Ability3 { get; set; }

        public string Ability4 { get; set; }

        public Abilities()
        {
        }

        public Abilities(int? id, int pokemonNumber, string ability1,
            string ability2 = default(string), string ability3 = default(string),
            string ability4 = default(string))
        {
            this.Id = id;
            this.PokemonNumber = pokemonNumber;
            this.Ability1 = ability1;
            this.Ability2 = ability2;
            this.Ability3 = ability3;
            this.Ability4 = ability4;
        }
    }
}
