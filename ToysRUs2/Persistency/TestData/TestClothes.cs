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
                        Colour = colours[0],
                        Description = "This dress is very red and pretty",
                        Name = "Pretty red dress",
                        Price = 399.95,
                        Sex = sexes[1],
                        Size = sizes[3],
                        Type = types[0]
                    },
                    new Clothes
                    {
                        Colour = colours[2],
                        Description = "Purple t-shirt without any motives",
                        Name = "T-shirt",
                        Price = 1299.95,
                        Sex = sexes[0],
                        Size = sizes[6],
                        Type = types[2]
                    },
                    new Clothes
                    {
                        Colour = colours[1],
                        Description = "Blue dress shirt for when you want to get laid",
                        Name = "Dress shirt for men",
                        Price = 800,
                        Sex = sexes[0],
                        Size = sizes[5],
                        Type = types[4]
                    },

                };
            }
        }
    }
}