using webapi.DataPostgresSql.DataBase;
using webapi.Infrastructures;
using webapi.Models;

namespace webapi.DataPostgresSql.DataLayer
{
    public class PostgreSQLDataLayer:IProductDataLayer
    {
        #region field
        private readonly ProductDbContext? context =null;
        #endregion
        #region constructor
        public PostgreSQLDataLayer(ProductDbContext context)
        {
            this.context = context;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Récupérer la liste de produits à la base de données
        /// </summary>
        /// <returns></returns>
        public List<Product> GetList()
        {
           
            var query = from item in context?.Products
                        select item;
            return query.ToList();

        }
        #endregion
    }
}
