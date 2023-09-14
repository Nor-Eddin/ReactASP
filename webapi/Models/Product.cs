namespace webapi.Models
{
    public class Product
    {

        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public string DescriptionProduct { get; set; } = string.Empty;
        public float Price { get; set; }
        public string Image { get; set; }
        public Category Cat { get; set; }
        public Promotion? Promotions { get; set; }
    }
}
