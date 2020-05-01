using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Interfaces;
using Data.Models;
using Services.Interfaces;

namespace Services.Services
{
    public class NoveltyService : INoveltyService
    {
        public NoveltyService(IRepository<NoveltyDto> noveltyRepository)
        {
            _noveltyRepository = noveltyRepository;
        }

        private IRepository<NoveltyDto> _noveltyRepository;
        
        public async Task<bool> Create(NoveltyDto noveltyDto)
        {
            
            
            throw new NotImplementedException();
        }

        public async Task<NoveltyDto> Read(Guid noveltyId)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<NoveltyDto>> ReadMany(IList<Guid> noveltyIdsList)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(NoveltyDto novelty)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid noveltyId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteMany(IList<Guid> noveltyId)
        {
            throw new NotImplementedException();
        }
    }
}