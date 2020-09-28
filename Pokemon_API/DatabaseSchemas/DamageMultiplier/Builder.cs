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

        public async Task<MultiplierResponse> Build(string t1, string t2)
        {
            Models.Multiplier type1 = await multiplierTable.Get(t1);
            Models.Multiplier type2 = await multiplierTable.Get(t2);

            //need to do type multiplication

            return new MultiplierResponse(type1);
        }
    }
}
