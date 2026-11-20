namespace SignalRSample.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public int Count { get; set; }
    }
}
