using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.MVCUI.Models.Entities;

namespace Project.MVCUI.Models.Configurations
{
    public class UserProfileConfiguration : BaseConfiguration<UserProfile>
    {
        public override void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            base.Configure(builder);
        }
    }
}
