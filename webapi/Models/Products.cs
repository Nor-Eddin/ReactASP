

namespace webapi.Models
{
    public class Products
    {
        #region
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Picture { get; set; }
        public Categoy Categories { get; set; }


        #endregion
    }
}
