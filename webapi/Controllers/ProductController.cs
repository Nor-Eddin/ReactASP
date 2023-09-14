using Microsoft.AspNetCore.Mvc;
using webapi.DataPostgresSql.DataBase;
using webapi.DataPostgresSql.DataLayer;
using webapi.Infrastructures;
using webapi.Models;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    /*private static readonly IEnumerable<Product> Products = new[]
    {
        new Product{Id=1,ProductName="seviette",DescriptionProduct="azertdfghxcvbsdfgh",Price=5,Image="sdfghj",},
        new Product{Id=2,ProductName="seviette",DescriptionProduct="azertdfghxcvbsdfgh",Price=10,Image="sdfghj",},
        new Product{Id=3,ProductName="seviette",DescriptionProduct="azertdfghxcvbsdfgh",Price=8,Image="sdfghj",},
        
    };*/
    /*private static readonly IEnumerable<Category> Categories = new[]
    {
        new Category{CatId=1,CategoryName="Fruit"},
        new Category{CatId=2,CategoryName="Legume"}
    };*/

    private readonly ILogger<ProductController> _logger;
    private readonly IProductDataLayer _productDataLayer;

    public ProductController(ILogger<ProductController> logger,IConfiguration configuration,IProductDataLayer dataLayerProduct)
    {
        _logger = logger;
        _productDataLayer = dataLayerProduct;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        //var dataLayer = new PostgreSQLDataLayer();
        
        return this._productDataLayer.GetList().ToArray();
    }
}
