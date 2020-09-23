using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Moves.Tables
{
    public class Flags : TableQueries<Models.Flags> {

        public override string Database => "Moves";
        public override string TableName => "Flags";

        public Flags() { }

        public async Task<List<Models.Flags>> GetAll(int number)
        {
            
            return null;
        }

        public async Task<Models.Flags> Get(int number)
        {
            
            return null;
        }

        public async Task<Models.Flags> Insert(Models.Flags obj)
        {
            
            return null;
        }

        public async Task Delete(int number)
        {
            
        }
    }
}
