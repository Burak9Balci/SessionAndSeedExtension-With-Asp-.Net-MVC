using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.MVCUI.Models.Entities;

namespace Project.MVCUI.Models.Configurations
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Orders).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserID);
            builder.HasOne(x =>x.UserProfile).WithOne(x =>x.AppUser).HasForeignKey<UserProfile>(x =>x.ID);
        }
    }
}
