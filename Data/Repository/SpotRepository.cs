using System;
using System.Threading.Tasks;
using Common.Models;
using Data.Interfaces;
using Data.Repository.Base;

namespace Data.Repository
{
    public class SpotRepository : BaseRepository<Spot>, ISpotRepository
    {

        public async Task<Spot> Read(double lat, double lon)
        {
            throw new NotImplementedException();
        }
    }
}