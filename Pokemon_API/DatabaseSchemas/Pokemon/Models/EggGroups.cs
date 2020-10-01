using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class EggGroups : DatabaseTable<EggGroups>
    {
        public int? Id { get; set; }

        public int PokemonNumber { get; set; }

        public string EggGroup1 { get; set; }

        public string EggGroup2 { get; set; }

        public EggGroups()
        {
        }

        public EggGroups(int? id, int pokemonNumber, string eggGroup1, string eggGroup2)
        {
            this.Id = id;
            this.PokemonNumber = pokemonNumber;
            this.EggGroup1 = eggGroup1;
            this.EggGroup2 = eggGroup2;
        }
    }
}
