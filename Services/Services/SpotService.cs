using System;
using System.Threading.Tasks;
using Common.Models;
using Common.Models.Enums;
using Data.Interfaces;
using Services.Interfaces;

namespace Services.Services
{
    public class SpotService : ISpotService
    {
        public SpotService(ILocationService locationService, ISpotRepository spotRepository)
        {
            _locationService = locationService;
            _spotRepository = spotRepository;
        }

        private readonly ISpotRepository _spotRepository;
        private readonly ILocationService _locationService;

        #region public methods
        public async Task AddSpot(double lat, double lon, int? grade = null, string description = null)
        {
            var location = new Location
            {
                Latitude = new Coordinate
                {
                    Value = lat,
                    Type = CoordinateTypeEnum.Latitude,
                    DmsCoordinate = _locationService.CalculateDms(lat, CoordinateTypeEnum.Latitude),
                },
                Longitude = new Coordinate
                {
                    Value = lon,
                    Type = CoordinateTypeEnum.Longitude,
                    DmsCoordinate = _locationService.CalculateDms(lon, CoordinateTypeEnum.Longitude)
                }
            };
            
            var spot = new Spot
            {
                Location = location,
                Id = Guid.NewGuid()
            };
            
            if (grade.HasValue && description != null)
            {
                spot.Reviews.Add(new Review
                {
                    Description = description,
                    Grade = grade.Value
                });
            }

            await _spotRepository.Create(spot);
        }

        public async Task<Spot> GetSpot(Guid id)
        {
            return await _spotRepository.Read(id);
        }

        public async Task<Spot> GetSpot(double lat, double lon)
        {
            return await _spotRepository.Read(lat, lon);
        }

        public async Task DeleteSpot(Guid id)
        {
            await _spotRepository.Delete(id);
        }

        public async Task AddReview(Guid id, int grade, string description)
        {
            var spot = await _spotRepository.Read(id);

            spot.Reviews.Add(new Review
            {
                Grade = grade,
                Description = description
            });

            await _spotRepository.Update(spot);
        }
        
        #endregion
    }
}