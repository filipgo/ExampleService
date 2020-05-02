using System;
using System.Threading.Tasks;
using Common.Models;
using Common.Models.Enums;
using Common.Models.Requests;
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
        public async Task AddSpot(CreateSpotRequest request)
        {
            var location = new Location
            {
                Latitude = new Coordinate
                {
                    Value = request.Lat,
                    Type = CoordinateTypeEnum.Latitude,
                    DmsCoordinate = _locationService.CalculateDms(request.Lat, CoordinateTypeEnum.Latitude),
                },
                Longitude = new Coordinate
                {
                    Value = request.Lon,
                    Type = CoordinateTypeEnum.Longitude,
                    DmsCoordinate = _locationService.CalculateDms(request.Lon, CoordinateTypeEnum.Longitude)
                }
            };
            
            var spot = new Spot
            {
                Location = location,
                Id = Guid.NewGuid()
            };
            
            if (request.Grade.HasValue && request.Description != null)
            {
                spot.Reviews.Add(new Review
                {
                    Description = request.Description,
                    Grade = request.Grade.Value
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