using System.ComponentModel;

namespace B2C2_Relaties.Models.ViewModel
{
    public class ProductViewModel
    {
        // properties van product 
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Category>? Categories { get; set; }

        /// <summary>
        /// Property om categorie toe te voegen. In een eindsituatie zou je dit wellicht anders implementeren
        /// </summary>
        [DisplayName("Enter category Id to add")]
        public int? CategoryToAdd { get; set; }
    }
}
