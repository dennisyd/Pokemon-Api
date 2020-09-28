using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

using Pokemon_API.ResponseModels;

namespace Pokemon_API.DatabaseSchemas.Pokemon
{
    public class Builder
    {
        private Tables.Abilities abilitiesTables;
        private Tables.BaseStats baseStatsTable;
        private Tables.EggGroups eggGroupsTable;
        private Tables.Evolutions evolutionsTable;
        private Tables.GenderRatio genderRatioTable;
        private Tables.Moves movesTable;
        private Tables.Pokemon pokemonTable;
        private Tables.Types typesTable;

        public Builder()
        {
            abilitiesTables = new Tables.Abilities();
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

            List<string> abilities = (await abilitiesTables.Get(pokemon.Number)).Select(a => a.Ability).ToList();
            Models.BaseStats baseStats = await baseStatsTable.Get(pokemon.Number);
            List<string> eggGroups = (await eggGroupsTable.Get(pokemon.Number)).Select(e => e.EggGroup).ToList();
            List<string> evolutions = (await evolutionsTable.Get(pokemon.Number)).Select(e => e.Evolution).ToList();
            Models.GenderRatio genderRatio = await genderRatioTable.Get(pokemon.Number);
            List<Models.Moves> moves = await movesTable.Get(pokemon.Number);

            Models.Types typesModel = await typesTable.Get(pokemon.Number);
            List<string> types = new List<string>() { typesModel.Type1 };
            if (!string.IsNullOrEmpty(typesModel.Type2)) {
                types.Add(typesModel.Type1);
            }

            return new PokemonResponse(pokemon, genderRatio, baseStats, moves,
                abilities, evolutions, eggGroups, types);
        }
    }
}
