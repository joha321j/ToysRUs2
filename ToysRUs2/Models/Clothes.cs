using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToysRUs2.Models
{
    public class Clothes
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Sex Sex { get; set; }
        public Type Type { get; set; }
        public List<Size> Sizes { get; set; }
        public List<Colour> Colours { get; set; }
        public ICollection<ClothingImage> Images { get; set; }
    }

}