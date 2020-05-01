using System;

namespace Data.Models
{
    public class Coordinate
    {
        public Coordinate(double value)
        {
            Value = value;

        }
        
        // ReSharper disable once MemberCanBePrivate.Global
        public double Value { get;}
        
        private int Degree { get; set; }
        
        private int Minutes { get; set; }

        private int Seconds { get; set; }
        
        private double DecimalSeconds { get; set; }


        public string GetDmsValue(bool withDecimalSeconds = false) //DMS if Degree Minute Second format of Longitude/Latitude 
        {
            return $"";
        }

        private void CalculateDms()
        {
            //TODO compare with Floor()
            var rest = Value%1;
            Degree = Convert.ToInt32(Value - rest);

            var rest2 = rest % (1.0 / 60);
            Minutes = Convert.ToInt32(rest - rest2);

            var rest3 = rest2 % (1.0 / 360);
            Seconds = Convert.ToInt32(rest2 - rest3);

            DecimalSeconds = Math.Round(rest3, 10);

        }
    }
}