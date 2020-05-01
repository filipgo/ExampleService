using System;
using Data.Models.Enums;

namespace Data.Models
{
    public class Coordinate
    {
        public Coordinate(double value, CoordinateTypeEnum type)
        {
            Value = value;
            Type = type;
            CalculateDms();
        }
        
        // ReSharper disable once MemberCanBePrivate.Global
        public double Value { get;}
        
        private CoordinateTypeEnum Type { get; set; }
        
        private CoordinateDirectionEnum Direction { get; set; }
        
        private int Degree { get; set; }
        
        private int Minutes { get; set; }

        private int Seconds { get; set; }
        
        private double DecimalSeconds { get; set; }


        public string GetDmsValue(bool withDecimalSeconds = false) //DMS if Degree Minute Second format of Longitude/Latitude 
        {
            string seconds = withDecimalSeconds == true ? $"{Seconds}.{DecimalSeconds}" : $"{Seconds}";
            return $"{Degree}\u00b0 {Minutes}' {seconds}\"";
        }

        private void CalculateDms()
        {
            //TODO compare with Floor()
            var rest = Value%1;
            Degree = Convert.ToInt32(Value - rest);

            var rest2 = rest % (1.0 / 60);
            Minutes = Convert.ToInt32(60 * (rest - rest2));

            var rest3 = rest2 % (1.0 / 360);
            Seconds = Convert.ToInt32(3600 * (rest2 - rest3));

            DecimalSeconds = Math.Round(3600 * rest3, 4);
        }
    }
}