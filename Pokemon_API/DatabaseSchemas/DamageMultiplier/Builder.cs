using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

using Pokemon_API.ResponseModels;

namespace Pokemon_API.DatabaseSchemas.DamageMultiplier
{
    public class Builder
    {

        private Tables.Multiplier multiplierTable;

        public Builder()
        {
            multiplierTable = new Tables.Multiplier();
        }

        public async Task<MultiplierResponse> Build(string t1)
        {
            Models.Multiplier type1 = await multiplierTable.Get(t1);
            return new MultiplierResponse(type1);
        }

        public MultiplierResponse CombineTypes(MultiplierResponse t1, MultiplierResponse t2)
        {
            Models.Multiplier combinedType = new Models.Multiplier(
                id: null,
                name: $"{t1.Name}_{t2.Name}",
                normal: t1.Normal * t2.Normal,
                fighting: t2.Fighting * t2.Fighting,
                flying: t1.Flying * t2.Flying,
                poison: t1.Poison * t2.Poison,
                ground: t1.Ground * t2.Ground,
                rock: t1.Rock * t2.Rock,
                bug: t2.Bug * t2.Bug,
                ghost: t1.Ghost * t2.Ghost,
                steel: t1.Steel * t2.Steel,
                fire: t1.Fire * t2.Fire,
                water: t1.Water * t2.Water,
                grass: t1.Grass * t2.Grass,
                electric: t1.Electric * t2.Electric,
                psychic: t1.Psychic * t2.Psychic,
                ice: t1.Ice * t2.Ice,
                dragon: t1.Dragon * t2.Dragon,
                dark: t1.Dark * t2.Dark,
                fairy: t1.Fairy * t2.Fairy
            );

            return new MultiplierResponse(combinedType);  
        }
    }
}
