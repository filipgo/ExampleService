using System;
using Data.Models;
using Data.Models.Enums;
using Services.Interfaces;

namespace Services.Services
{
    public class LocationService : ILocationService
    {
        public DmsCoordinate CalculateDms(double value, CoordinateTypeEnum type)
        {
            var result = new DmsCoordinate();
            
            var rest = value%1;
            result.Degree = Convert.ToInt32(value - rest);

            var rest2 = rest % (1.0 / 60);
            result.Minutes = Convert.ToInt32(60 * (rest - rest2));

            var rest3 = rest2 % (1.0 / 360);
            result.Seconds = Convert.ToInt32(3600 * (rest2 - rest3));

            result.DecimalSeconds = Math.Round(3600 * rest3, 4);

            return result;
        }

        public CoordinateDirectionEnum CalculateDirection(double value, CoordinateTypeEnum type)
        {
            CoordinateDirectionEnum result;

            if (type == CoordinateTypeEnum.Latitude)
            {
                result = value < 0 ? CoordinateDirectionEnum.S : CoordinateDirectionEnum.N;
            }
            else
            {
                result = value < 0 ? CoordinateDirectionEnum.W : CoordinateDirectionEnum.E;
            }

            return result;
        }
    }
}