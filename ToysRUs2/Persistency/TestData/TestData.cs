using System.Collections.Generic;
using System.Linq;
using ToysRUs2.Models;

namespace ToysRUs2.Persistency.TestData
{
    public static class TestData
    {
        public static void Seed(ClothesDatabaseContext clothesDatabaseContext)
        {
            TestColours.Seed(clothesDatabaseContext);
            TestSexes.Seed(clothesDatabaseContext);
            TestSizes.Seed(clothesDatabaseContext);
            TestTypes.Seed(clothesDatabaseContext);
            TestClothes.Seed(clothesDatabaseContext);
        }
    }
}