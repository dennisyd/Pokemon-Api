using Newtonsoft.Json;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.Moves.Models
{
    public class Flags : DatabaseTable<Flags>
    {
        public int? Id { get; set; }

        public int MoveNumber { get; set; }

        public string Flag { get; set; }

        public Flags()
        {
        }

        public Flags(int? id, int moveNumber, string flag)
        {
            this.Id = id;
            this.MoveNumber = moveNumber;
            this.Flag = flag;
        }
    }
}
