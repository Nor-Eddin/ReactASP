namespace webapi.Models
{
    public class Promotions
    {
        public int SaveOff { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; } = DateTime.MinValue;
    }
}
