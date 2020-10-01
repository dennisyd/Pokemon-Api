using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Models
{
    public class Types : DatabaseTable<Types>
    {
        public int? Id { get; set; }

        public int PokemonNumber { get; set; }

        public string Type1 { get; set; }

        public string Type2 { get; set; }

        public Types()
        {
        }

        public Types(int? id, int pokemonNumber, string type1, string type2 = null)
        {
            this.Id = id;
            this.PokemonNumber = pokemonNumber;
            this.Type1 = type1;
            this.Type2 = type2;
        }
    }
}
