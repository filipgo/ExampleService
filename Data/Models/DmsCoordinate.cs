using Data.Models.Enums;

namespace Data.Models
{
    public class DmsCoordinate
    {
        public DmsCoordinate()
        {
        }

        public int Degree { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public double DecimalSeconds { get; set; }

        public CoordinateDirectionEnum Direction { get; set; }

        public string
            GetDmsValue(bool withDecimalSeconds = false) //DMS if Degree Minute Second format of Longitude/Latitude 
        {
            string seconds = withDecimalSeconds == true ? $"{Seconds}.{DecimalSeconds}" : $"{Seconds}";
            return $"{Degree}\u00b0 {Direction.ToString()} {Minutes}' {seconds}\"";
        }
    }
}