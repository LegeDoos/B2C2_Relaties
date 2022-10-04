using System.ComponentModel.DataAnnotations;

namespace B2C2_Relaties.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }


        public List<Category>? Categories { get; set; }
    }
}
