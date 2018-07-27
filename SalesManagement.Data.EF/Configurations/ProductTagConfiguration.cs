using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagement.Data.EF.Extensions;
using SalesManagement.Data.Entities;

namespace SalesManagement.Data.EF.Configurations
{
    public class ProductTagConfiguration: ModelBuilderExtensions.DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50).IsRequired().HasColumnType("varchar(50)");
        }
    }
}