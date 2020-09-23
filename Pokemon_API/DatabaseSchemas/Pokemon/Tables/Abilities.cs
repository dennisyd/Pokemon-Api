using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Tables
{
    public class Abilities : TableQueries<Models.Abilities>
    {
        public override string Database => "Pokemon";
        public override string TableName => "Flags";

        public Abilities() { }

        public async Task<List<Models.Abilities>> GetAll(int number)
        {

            return null;
        }

        public async Task<Models.Abilities> Get(int number)
        {

            return null;
        }

        public async Task<Models.Abilities> Insert(Models.Abilities obj)
        {

            return null;
        }

        public async Task Delete(int number)
        {

        }
    }
}
