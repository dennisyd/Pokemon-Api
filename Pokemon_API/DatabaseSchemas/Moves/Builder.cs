using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

using Pokemon_API.ResponseModels;

namespace Pokemon_API.DatabaseSchemas.Moves
{
    public class Builder
    {
        private Tables.Flags flagsTable;
        private Tables.Move movesTable;

        public Builder()
        {
            flagsTable = new Tables.Flags();
            movesTable = new Tables.Move();
        }

        public async Task<MoveResponse> Build(string id)
        {
            Models.Moves move = (int.TryParse(id, out int number)) ?
                await movesTable.Get(number) : await movesTable.Get(id);

            List<string> flags = (await flagsTable.Get(move.Number)).Select(f => f.Flag).ToList();

            return new MoveResponse(move, flags);
        }
    }
}
