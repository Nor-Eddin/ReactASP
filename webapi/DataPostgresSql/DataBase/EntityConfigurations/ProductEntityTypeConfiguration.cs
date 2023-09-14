using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.Models;

namespace webapi.DataPostgresSql.DataBase.EntityConfigurations
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        #region public methods
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(item => item.IdProduct);
            builder.ToTable("Product");
            

        }
        #endregion
    }
}
