using System;
using System.Threading.Tasks;
using Common.Models;
using Common.Models.Requests;

namespace Services.Interfaces
{
    public interface ISpotService
    {
        Task AddSpot(CreateSpotRequest request);

        Task<Spot> GetSpot(Guid id);

        Task<Spot>GetSpot(double lat, double lon);

        Task DeleteSpot(Guid id);

        Task AddReview(Guid id, int grade, string description);
    }
}