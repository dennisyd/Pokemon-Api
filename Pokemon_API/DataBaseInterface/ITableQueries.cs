using System;
using System.Threading.Tasks;

namespace Pokemon_API.DataBaseInterface
{
    public interface ITableQueries<T>
    {
        Task<T> Get(int number);
        Task<T> Insert(T obj);
        Task Delete(int number);
    }
}
