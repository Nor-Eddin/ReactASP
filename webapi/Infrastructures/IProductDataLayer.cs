using webapi.Models;

namespace webapi.Infrastructures
{
    /// <summary>
    /// Isole l'accés à la base de données
    /// </summary>
    public interface IProductDataLayer
    {
        /// <summary>
        /// Retourne la liste complétes de produits
        /// </summary>
        /// <returns></returns>
        List<Product> GetList();
    }
}
