using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pokemon_API.DataBaseInterface
{
    public interface ITableQueriesAll<T>
    {
        Task<List<T>> GetAll(int number);
    }
}
