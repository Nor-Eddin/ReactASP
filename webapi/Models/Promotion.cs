namespace webapi.Models
{
    public class Promotion
    {
        public int IdPromotion { get; set; }
        public DateOnly DateToStart { get; set; }
        public DateOnly DateToEnd { get; set; }
        public decimal TauxPromotion { get; set; }
    }
}
