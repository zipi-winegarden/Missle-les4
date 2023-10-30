namespace WebApplication1.model
{
    public class Location
    {
        public string city { get; set; }
        public DateTime date { get; set; }
        public DateTime endDate { get; set; }
        public string location { get; set; }

        public override string? ToString()
        {
            return $"city: {city} " +
                 $"dateS:{date}" +
                 $"dateE:{endDate}"
                 +$"location:{location}";
        }
    }
}