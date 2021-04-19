using System.Collections.Generic;
using System.Linq;
using ToysRUs2.Models;

namespace ToysRUs2.Persistency.TestData
{
    public static class TestSizes
    {
        public static void Seed(ClothesDatabaseContext clothesDatabaseContext)
        {
            if (!clothesDatabaseContext.Sizes.Any())
            {
                List<Size> seedSizes = new List<Size>
                {
                    new Size
                    {
                        Value = "XXS"
                    },
                    new Size
                    {
                        Value = "XS"
                    },
                    new Size
                    {
                        Value = "Small"
                    },
                    new Size
                    {
                        Value = "Medium"
                    },
                    new Size
                    {
                        Value = "Large"
                    },
                    new Size
                    {
                        Value = "XL"
                    },
                    new Size
                    {
                        Value = "XXL"
                    },
                };

                clothesDatabaseContext.Sizes.AddRange(seedSizes);
                clothesDatabaseContext.SaveChanges();
            }
        }
    }
}