namespace Common.Models.Requests
{
    public class CreateSpotRequest : BaseRequest
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        
        public int? Grade { get; set; }
        public string Description { get; set; }
        
    }
}