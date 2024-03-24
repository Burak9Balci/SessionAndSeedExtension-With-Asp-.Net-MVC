using Microsoft.EntityFrameworkCore;
using Project.MVCUI.Models.Configurations;
using Project.MVCUI.Models.Entities;
using Project.MVCUI.Models.ExtensionClasses.DataSeedExtensions;

namespace Project.MVCUI.Models.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new UserProfileConfiguration());
            CategoryDataSeedExtension.SeedCategories(modelBuilder);
        }
    }
}
