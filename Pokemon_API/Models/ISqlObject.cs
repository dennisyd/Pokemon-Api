
using Newtonsoft.Json;

namespace Pokemon_API.Models
{
    public interface ISqlObject
    {
        [JsonIgnore]
        string SqlInsert { get; }

        [JsonIgnore]
        string SqlValues { get; }
    }
}
