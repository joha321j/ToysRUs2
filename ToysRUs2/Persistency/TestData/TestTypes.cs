
using System.Collections.Generic;
using System.Linq;
using ToysRUs2.Models;

namespace ToysRUs2.Persistency.TestData
{
    public static class TestTypes
    {
        public static void Seed(ClothesDatabaseContext clothesDatabaseContext)
        {
            if (!clothesDatabaseContext.Types.Any())
            {
                List<Type> seedTypes = new List<Type>
                {
                    new Type
                    {
                        Value = "Dress"
                    },
                    new Type
                    {
                        Value = "Pants"
                    },
                    new Type
                    {
                        Value = "T-Shirt"
                    },
                    new Type
                    {
                        Value = "Hoodie"
                    },
                    new Type
                    {
                        Value = "Dress Shirt"
                    },
                    new Type
                    {
                        Value = "Cardigan"
                    }
                };
                
                clothesDatabaseContext.Types.AddRange(seedTypes);
                clothesDatabaseContext.SaveChanges();
            }
        }
    }
}