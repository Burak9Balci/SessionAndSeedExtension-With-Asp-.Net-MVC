using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.MVCUI.Models.Entities;

namespace Project.MVCUI.Models.Configurations
{
    public class OrderConfiguration : BaseConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.HasMany(x =>x.OrderDetails).WithOne(x =>x.Order).HasForeignKey(x =>x.OrderID).IsRequired();
        }
    }
}
