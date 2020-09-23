using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Pokemon.Tables
{
    public class BaseStats : TableQueries<Models.BaseStats>
    {
        public override string Database => "Pokemon";
        public override string TableName => "BaseStats";

        public BaseStats() { }

        public async Task<Models.BaseStats> Get(int number)
        {

            return null;
        }

        public async Task<Models.BaseStats> Insert(Models.BaseStats obj)
        {

            return null;
        }

        public async Task Delete(int number)
        {

        }
    }
}
