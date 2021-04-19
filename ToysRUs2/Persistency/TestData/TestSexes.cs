using System.Collections.Generic;
using System.Linq;
using ToysRUs2.Models;

namespace ToysRUs2.Persistency.TestData
{
    public static class TestSexes
    {
        public static void Seed(ClothesDatabaseContext clothesDatabaseContext)
        {
            if (!clothesDatabaseContext.Sexes.Any())
            {
                List<Sex> seedSexes = new List<Sex>
                {
                    new Sex
                    {
                        Value = "Male"
                    },
                    new Sex
                    {
                        Value = "Female"
                    }
                };
                
                clothesDatabaseContext.Sexes.AddRange(seedSexes);
                clothesDatabaseContext.SaveChanges();
            }
        }
    }
}