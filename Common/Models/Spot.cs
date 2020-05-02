using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.Models
{
    public class Spot
    {
        public Location Location { get; set; }
        public Guid Id { get; set; }
        public IList<Review> Reviews { get; set; } = new List<Review>();

        public double Rating
        {
            get
            {
                return (double) Reviews.Sum(rev => rev.Grade)/Reviews.Count;
            }
        }
    }
}