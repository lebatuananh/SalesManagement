using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagement.Data.EF.Extensions;
using SalesManagement.Data.Entities;

namespace SalesManagement.Data.EF.Configurations
{
    public class TagConfiguration: ModelBuilderExtensions.DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50).IsRequired().HasColumnType("varchar(50)");
        }
    }
}