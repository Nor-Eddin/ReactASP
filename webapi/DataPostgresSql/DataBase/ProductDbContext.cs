using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.DataPostgresSql.DataBase
{
    public class ProductDbContext:DbContext
    {
        #region constructor
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }

        public ProductDbContext()
        {

        }
        #endregion
        #region public methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityConfigurations.ProductEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.CategoryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EntityConfigurations.PromotionEntityTypeConfiguration());

        }
        #endregion
        #region properties
        public DbSet<Product>Products {  get; set; }
        public DbSet<Product>Categories { get; set; }
        public DbSet<Product> Promotions { get; set; }
        #endregion
    }
}
