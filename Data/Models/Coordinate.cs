using System;
using Data.Models.Enums;

namespace Data.Models
{
    public class Coordinate
    {
        public Coordinate(double value, CoordinateTypeEnum type)
        {
            Value = value;
            _type = type;
            CalculateDms();
        }
        
        // ReSharper disable once MemberCanBePrivate.Global
        public double Value { get;}

        private readonly CoordinateTypeEnum _type;
        private CoordinateDirectionEnum _direction;

        private int _degree;
        private int _minutes;
        private int _seconds;
        private double _decimalSeconds;


        public string GetDmsValue(bool withDecimalSeconds = false) //DMS if Degree Minute Second format of Longitude/Latitude 
        {
            string seconds = withDecimalSeconds == true ? $"{_seconds}.{_decimalSeconds}" : $"{_seconds}";
            return $"{_degree}\u00b0 {_direction.ToString()} {_minutes}' {seconds}\"";
        }

        
        private void CalculateDms()
        {
            _direction = CalculateDirection();
            
            var rest = Value%1;
            _degree = Convert.ToInt32(Value - rest);

            var rest2 = rest % (1.0 / 60);
            _minutes = Convert.ToInt32(60 * (rest - rest2));

            var rest3 = rest2 % (1.0 / 360);
            _seconds = Convert.ToInt32(3600 * (rest2 - rest3));

            _decimalSeconds = Math.Round(3600 * rest3, 4);
        }

        public CoordinateDirectionEnum CalculateDirection()
        {
            CoordinateDirectionEnum result;

            if (_type == CoordinateTypeEnum.Latitude)
            {
                result = Value < 0 ? CoordinateDirectionEnum.S : CoordinateDirectionEnum.N;
            }
            else
            {
                result = Value < 0 ? CoordinateDirectionEnum.W : CoordinateDirectionEnum.E;
            }

            return result;
        }
    }
}