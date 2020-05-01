using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class Spot
    {
        public Coordinates Coordinates { get; set; }
        
        public Guid Id { get; set; }
        
        public IList<Review> Reviews { get; set; }
        
        public double Rating { get; set; }
    }
}