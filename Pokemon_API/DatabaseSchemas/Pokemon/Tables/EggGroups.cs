using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Queries
{
    public class EggGroups : TableQueries<Models.EggGroups>
    {
        public override string Database => "Pokemon";
        public override string TableName => "EggGroups";

        public EggGroups() { }

        public async Task<List<Models.EggGroups>> GetAll(int number)
        {

            return null;
        }

        public async Task<Models.EggGroups> Get(int number)
        {

            return null;
        }

        public async Task<Models.EggGroups> Insert(Models.EggGroups obj)
        {

            return null;
        }

        public async Task Delete(int number)
        {
            
        }
    }
}
