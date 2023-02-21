
namespace Ban.Domain
{
    public class Ban
    {
        public int id { get; set; }
        public int entity { get; set; }
        public string until { get; set; }
        public string reason { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }

    }
}
