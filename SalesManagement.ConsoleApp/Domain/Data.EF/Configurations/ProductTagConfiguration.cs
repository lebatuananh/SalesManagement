using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagement.ConsoleApp.Domain.Data.EF.Extensions;
using SalesManagement.ConsoleApp.Domain.Data.Entities;

namespace SalesManagement.ConsoleApp.Domain.Data.EF.Configurations
{
    public class ProductTagConfiguration: ModelBuilderExtensions.DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50).IsRequired().HasColumnType("varchar(50)");
        }
    }
}