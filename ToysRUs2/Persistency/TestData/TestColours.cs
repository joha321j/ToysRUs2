using System.Collections.Generic;
using System.Linq;
using ToysRUs2.Models;

namespace ToysRUs2.Persistency.TestData
{
    public static class TestColours
    {
        public static void Seed(ClothesDatabaseContext clothesDatabaseContext)
        {
            if (!clothesDatabaseContext.Colours.Any())
            {
                List<Colour> seedColours = new List<Colour>
                {
                    new Colour
                    {
                        Value = "Red"
                    },
                    new Colour
                    {
                        Value = "Blue"
                    },
                    new Colour
                    {
                        Value = "Purple"
                    },
                    new Colour
                    {
                        Value = "Green"
                    }
                };
                
                clothesDatabaseContext.Colours.AddRange(seedColours);
                clothesDatabaseContext.SaveChanges();
            }
        }
    }
}