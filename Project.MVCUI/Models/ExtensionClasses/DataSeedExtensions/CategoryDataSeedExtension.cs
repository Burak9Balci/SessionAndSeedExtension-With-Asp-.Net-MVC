using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Project.MVCUI.Models.Entities;

namespace Project.MVCUI.Models.ExtensionClasses.DataSeedExtensions
{
    public static class CategoryDataSeedExtension
    {
        public static void SeedCategories(ModelBuilder builder)
        {
            List<Category> categories = new();
            for (int i = 1; i < 11; i++)
            {
                Category c = new()
                {
                    ID = i,
                    CategoryName = new Commerce("tr").Categories(1)[0],
                    Description = new Lorem("tr").Sentence(10)
                };
                categories.Add(c);
            }
            builder.Entity<Category>().HasData(categories);
        }
    }
}
