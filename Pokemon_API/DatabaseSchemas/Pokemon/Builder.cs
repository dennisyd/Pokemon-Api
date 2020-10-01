using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

using Pokemon_API.ResponseModels;

namespace Pokemon_API.DatabaseSchemas.Pokemon
{
    public class Builder
    {
        private Tables.Abilities abilitiesTable;
        private Tables.BaseStats baseStatsTable;
        private Tables.EggGroups eggGroupsTable;
        private Tables.Evolutions evolutionsTable;
        private Tables.GenderRatio genderRatioTable;
        private Tables.Moves movesTable;
        private Tables.Pokemon pokemonTable;
        private Tables.Types typesTable;

        public Builder()
        {
            abilitiesTable = new Tables.Abilities();
            baseStatsTable = new Tables.BaseStats();
            eggGroupsTable = new Tables.EggGroups();
            evolutionsTable = new Tables.Evolutions();
            genderRatioTable = new Tables.GenderRatio();
            movesTable = new Tables.Moves();
            pokemonTable = new Tables.Pokemon();
            typesTable = new Tables.Types();
        }

        public async Task<PokemonResponse> Build(string id)
        {
            Models.Pokemon pokemon = (int.TryParse(id, out int number)) ?
                await pokemonTable.Get(number) : await pokemonTable.Get(id);

            List<string> abilities = await getAbilities(pokemon.Number);
            Models.BaseStats baseStats = await baseStatsTable.Get(pokemon.Number);
            List<string> eggGroups = await getEggGroups(pokemon.Number);
            List<string> evolutions = (await evolutionsTable.Get(pokemon.Number)).Select(e => e.Evolution).ToList();
            Models.GenderRatio genderRatio = await genderRatioTable.Get(pokemon.Number);
            List<Models.Moves> moves = await movesTable.Get(pokemon.Number);
            moves = (moves.Count > 0) ? null : moves;

            Models.Types typesModel = await typesTable.Get(pokemon.Number);
            List<string> types = new List<string>() { typesModel.Type1 };
            if (!string.IsNullOrEmpty(typesModel.Type2)) {
                types.Add(typesModel.Type2);
            }

            return new PokemonResponse(pokemon, genderRatio, baseStats, moves,
                abilities, evolutions, eggGroups, types);
        }

        private async Task<List<string>> getAbilities(int pokemonNumber)
        {
            Models.Abilities abilities = await abilitiesTable.Get(pokemonNumber);
            List<string> list = new List<string>() { abilities.Ability1, abilities.Ability2, abilities.Ability3, abilities.Ability4 };
            list.RemoveAll(item => string.IsNullOrEmpty(item));
            return list;
        }

        private async Task<List<string>> getEggGroups(int pokemonNumber)
        {
            Models.EggGroups eggGroup = await eggGroupsTable.Get(pokemonNumber);
            List<string> list = new List<string>() { eggGroup.EggGroup1, eggGroup.EggGroup2 };
            list.RemoveAll(item => string.IsNullOrEmpty(item));
            return list;
        }

        private async Task<List<string>> getTypes(int pokemonNumber)
        {
            Models.Types types = await typesTable.Get(pokemonNumber);
            List<string> list = new List<string>() { types.Type1, types.Type2 };
            list.RemoveAll(item => string.IsNullOrEmpty(item));
            return list;
        }

    }
}
