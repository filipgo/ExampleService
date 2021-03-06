using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;

namespace Services.Interfaces
{
    public interface ISpotService
    {
        Task AddSpot(double lat, double lon, int? grade = null, string description = null);

        Task<Spot> GetSpot(Guid id);

        Task<Spot>GetSpot(double lat, double lon);

        Task DeleteSpot(Guid id);

        Task AddReview(Guid id, int grade, string description);
    }
}