using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.Models;

namespace webapi.DataPostgresSql.DataBase.EntityConfigurations
{
    public class PromotionEntityTypeConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.HasKey(item => item.IdPromotion);
            builder.ToTable("Promotion");
        }
    }
}
