using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Project.MVCUI.Models.Entities;

namespace Project.MVCUI.Models.ExtensionClasses.DataSeedExtensions
{
    public static class ProductDataSeedExtension
    {
        public static void SeedProducts(ModelBuilder model)
        {
            List<Product> products = new();
            for (int i = 1; i < 10; i++)
            {
                Product p = new()
                {
                    ID = i,
                    ProductName = new Commerce("tr").ProductName(),
                    UnitPrice = Convert.ToDecimal(new Commerce("tr").Price()),
                    CategoryID = i
                };
                products.Add(p);
            }
            model.Entity<Product>().HasData(products);
        }
    }
}
