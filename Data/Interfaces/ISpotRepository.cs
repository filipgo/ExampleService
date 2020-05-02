using System.Threading.Tasks;
using Common.Models;

namespace Data.Interfaces
{
    public interface ISpotRepository : IRepository<Spot>
    {
        Task<Spot> Read(double lat, double lon);
    }
}