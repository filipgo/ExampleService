using Data.Models;
using Data.Models.Enums;

namespace Services.Interfaces
{
    public interface ILocationService
    {
        DmsCoordinate CalculateDms(double value, CoordinateTypeEnum type);

        CoordinateDirectionEnum CalculateDirection(double value, CoordinateTypeEnum type);
    }
}