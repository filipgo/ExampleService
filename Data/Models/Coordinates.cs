using Data.Models.Enums;

namespace Data.Models
{
    public class Coordinates
    {
        public Coordinates(double latitude, double longitude)
        {
            Longitude = new Coordinate(longitude, CoordinateTypeEnum.Longitude);
            Latitude = new Coordinate(latitude, CoordinateTypeEnum.Latitude);
        }
        
        public Coordinate Longitude { get; set; }

        public Coordinate Latitude { get; set; }
    }
}