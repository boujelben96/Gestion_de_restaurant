using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_de_restaurant.Models
{
    public class Articles
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public string ImageUrl { get; set; }

        [ForeignKey("CategorieId")]
        public int CategorieId { get; set; }
        //public Categories Categories { get; set; }
    }
}
