using System.Collections.Generic;
using System.Linq;
using ToysRUs2.Models;

namespace ToysRUs2.Persistency.TestData
{
    public static class TestClothes
    {
        public static void Seed(ClothesDatabaseContext clothesDatabaseContext)
        {
            if (!clothesDatabaseContext.ClothingSet.Any())
            {
                List<Colour> colours = clothesDatabaseContext.Colours.ToList();
                List<Sex> sexes = clothesDatabaseContext.Sexes.ToList();
                List<Size> sizes = clothesDatabaseContext.Sizes.ToList();
                List<Type> types = clothesDatabaseContext.Types.ToList();

                List<Clothes> clothesList = new List<Clothes>
                {
                    new Clothes
                    {
                        Colours = colours,
                        Description = "This dress is very pretty",
                        Name = "Pretty red dress",
                        Price = 399.95,
                        Sex = sexes[1],
                        Sizes = sizes,
                        Type = types[0]
                    },
                    new Clothes
                    {
                        Colours = colours,
                        Description = "T-shirt without any motives",
                        Name = "T-shirt",
                        Price = 1299.95,
                        Sex = sexes[0],
                        Sizes = sizes,
                        Type = types[2]
                    },
                    new Clothes
                    {
                        Colours = colours,
                        Description = "Dress shirt for when you want to get laid",
                        Name = "Dress shirt for men",
                        Price = 800,
                        Sex = sexes[0],
                        Sizes = sizes,
                        Type = types[4]
                    },

                };
                
                clothesDatabaseContext.ClothingSet.AddRange(clothesList);
            }
        }
    }
}