using System.ComponentModel.DataAnnotations;

namespace Gestion_de_restaurant.Models
{
    public class Menu
    {
        [Key]
        public String Id { get; set; } // Renommé pour respecter une convention simple.

        [Required]
        [StringLength(100, ErrorMessage = "Le nom du menu ne peut pas dépasser 100 caractères.")]
        public string Nom { get; set; }  // Utilisez le français pour rester cohérent avec les autres modèles.

        [StringLength(500, ErrorMessage = "La description du menu ne peut pas dépasser 500 caractères.")]
        public string Description { get; set; }

        // Relation avec les articles
        public List<Article> Articles { get; set; } = new List<Article>(); // Initialisez la liste.
    }
}
