
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;

namespace Services.Interfaces
{
    public interface INoveltyService
    {
        Task<bool> Create(NoveltyDto noveltyDto);

        Task<NoveltyDto> Read(Guid noveltyId);

        Task<IList<NoveltyDto>> ReadMany(IList<Guid> noveltyIdsList);

        Task<bool> Update(NoveltyDto novelty);

        Task<bool> Delete(Guid noveltyId);
        
        Task<bool> DeleteMany(IList<Guid> noveltyId);
    }
}