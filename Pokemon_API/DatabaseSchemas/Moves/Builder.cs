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

        public Task<MoveResponse> Build(int id)
        {
            return this.Build(id.ToString());
        }

        public async Task<MoveResponse> Build(string id)
        {
            if(int.TryParse(id,out int result))
            {
                int number = int.Parse(id);
                Models.Moves move = await movesTable.Get(number);
                List<string> flags = (await flagsTable.Get(move.Number)).Select(f => f.Flag).ToList();
                return new MoveResponse(move, flags);
            }
            else
            {
                return new MoveResponse();
            }
        }
    }
}
