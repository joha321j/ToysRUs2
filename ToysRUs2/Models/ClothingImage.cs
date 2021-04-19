using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToysRUs2.Models
{
    public class ClothingImage
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Clothes")]
        public int ClothingId { get; set; }
        public string FileLocation { get; set; }
    }
}