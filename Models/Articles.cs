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
        public int CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public Categories Categories { get; set; }
    }
}
