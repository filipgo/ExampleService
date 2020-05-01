using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Models
{
    public class Spot
    {
        // public Spot(Location coords)
        // {
        //     Coordinates = coords;
        // }

        // public Spot(double latitude, double longitude) : this(new Location(latitude, longitude))
        //          {
        //          }

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

        // public void AddReview(int grade, string description)
        // {
        //     Reviews.Add(new Review()
        //     {
        //         Grade = grade,
        //         Description = description
        //     });
        // }
        //
    }
}