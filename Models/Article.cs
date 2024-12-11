using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_de_restaurant.Models
{
    public class Article
    {
        [Key]
        public String Id { get; set; }  // Utilisez un nom de clé plus générique.

        [Required]
        [StringLength(100)]
        public string Nom { get; set; }  // Simplifiez le nom pour plus de clarté.

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Le prix doit être supérieur à 0.")]
        public decimal Prix { get; set; }

        [Url]
        public string ImageUrl { get; set; }

        // Relation avec Menu
        public String MenuId { get; set; }
        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }

        // Relation avec Categorie
        [ForeignKey("CategorieId")]
        public String CategorieId { get; set; }
        
        public Categorie Categorie { get; set; }
    }
}
