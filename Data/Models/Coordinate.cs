namespace Data.Models
{
    public class Coordinate
    {
        public string Value { get; set; }
        
        public int Degree { get; set; }
        
        public int Minutes { get; set; }

        public int Seconds { get; set; }
        
        public int DecimalSeconds { get; set; }


        public string GetTraditionalNotationValue()
        {
            return $"";
        }
    }
}