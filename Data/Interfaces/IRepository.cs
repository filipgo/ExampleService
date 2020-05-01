using System;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> Read(Guid id);

        Task<bool> Create(T created);

        Task<bool> Update(T updated);

        Task<bool> Delete(Guid id);
    }
}