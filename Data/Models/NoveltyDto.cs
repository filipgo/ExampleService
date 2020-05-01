using System;

namespace Data.Models
{
    public class NoveltyDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }

        public DateTime CreationDateUtc { get; set; }
    }
}