namespace Data.Models
{
    public class UpdateNoveltyRequest : BaseRequest
    {
        
        public string Name { get; set; }

        public int Value { get; set; }
    }
}