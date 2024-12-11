using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_de_restaurant.Models
{
    public class Categorie
    {
        [Key]
        public String Id { get; set; }  // Utilisez un nom de clé primaire plus générique comme "Id".

        [Required]
        [StringLength(100, ErrorMessage = "Le nom de la catégorie ne peut pas dépasser 100 caractères.")]
        public string Nom { get; set; }  // Utilisez PascalCase.

        // Relation avec les articles
        public List<Article> Articles { get; set; } = new List<Article>();  // Initialisez la liste.
    }
}
