namespace Data.Models
{
    public class CreateNoveltyRequest : BaseRequest
    {
        public string Name { get; set; }

        public int Value { get; set; }
    }
}