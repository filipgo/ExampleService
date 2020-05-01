using System;
using System.Threading.Tasks;
using Data.Interfaces;
using Data.Models;
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