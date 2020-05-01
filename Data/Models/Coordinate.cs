namespace Data.Models
{
    public class Coordinate
    {
        public Coordinate(double value)
        {
            value = Value;
            
        }
        
        public double Value { get; }
        
        public int Degree { get; set; }
        
        public int Minutes { get; set; }

        public int Seconds { get; set; }
        
        public int DecimalSeconds { get; set; }


        public string GetDmsValue() //DMS if Degree Minute Second format of Longitude/Latitude 
        {
            return $"";
        }
    }
}