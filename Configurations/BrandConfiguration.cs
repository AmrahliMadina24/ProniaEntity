using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProniaAdmin.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasMany(x => x.ProductBrands).WithOne(x => x.Brand).HasForeignKey(x => x.BrandId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Cascade);

        }
    }
}