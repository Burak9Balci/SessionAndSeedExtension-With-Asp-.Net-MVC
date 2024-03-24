using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.MVCUI.Models.Entities;

namespace Project.MVCUI.Models.Configurations
{
    public class ProductConfiguration :BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.UnitPrice).HasColumnType("money");
            builder.HasMany(x =>x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).IsRequired();
        }
    }
}
