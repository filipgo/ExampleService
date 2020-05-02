using Common.Models;
using Common.Models.Enums;

namespace Services.Interfaces
{
    public interface ILocationService
    {
        DmsCoordinate CalculateDms(double value, CoordinateTypeEnum type);

        CoordinateDirectionEnum CalculateDirection(double value, CoordinateTypeEnum type);

        bool ValidateCoordinate(double value);
    }
}