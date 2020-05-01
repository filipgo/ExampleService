using System;

namespace Data.Entities
{
    public class Novelty
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }

        public DateTime CreationDateUtc { get; set; }
    }
}