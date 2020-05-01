using System;
using Data.Models.Enums;

namespace Data.Models
{
    public class Location
    {
        public Coordinate Longitude { get; set; }

        public Coordinate Latitude { get; set; }
        
        //TODO check for API to find country by lat & long
        public int CountryId { get; set; }
    }
}