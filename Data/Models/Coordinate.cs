using System;
using Data.Models.Enums;

namespace Data.Models
{
    public class Coordinate
    {
        
        // ReSharper disable once MemberCanBePrivate.Global
        public double Value { get; set; }

        public DmsCoordinate DmsCoordinate { get; set; }

        public CoordinateTypeEnum Type { get; set; }
    }
}