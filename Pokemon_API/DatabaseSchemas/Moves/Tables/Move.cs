using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Moves.Tables
{
    public class Move : TableQueries<Models.Moves>
    {
        private new string Database = "Moves";
        private new string TableName = "Move";

        public Move() { }

        public async Task<List<Models.Moves>> GetAllForPokemon(int number)
        {

            return null;
        }

        public async Task<Models.Moves> Get(string name)
        {

            return null;
        }

        public async Task<Models.Moves> Get(int number)
        {

            return null;
        }

        public async Task<Models.Moves> Insert(Models.Moves obj)
        {

            return null;
        }

        public async Task Delete(int number)
        {

        }
    }
}
