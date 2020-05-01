using System;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> Read(Guid id);

        Task Create(T created);

        Task Update(T updated);

        Task Delete(Guid id);
    }
}