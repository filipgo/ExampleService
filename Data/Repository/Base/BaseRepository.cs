using System;
using System.Threading.Tasks;
using Data.Interfaces;

namespace Data.Repository.Base
{
    public abstract class BaseRepository<T> : IRepository<T>
    {
        public async Task<T> Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(T created)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(T updated)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}