using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_de_restaurant.Models
{
    public class LigneCommande
    {
        [Key]
        public String Id { get; set; } // Simplification du nom de clé primaire.

        [Required]
        [ForeignKey("Article")]
        public String ArticleId { get; set; }
        public Article Article { get; set; } // Renommé pour indiquer qu'il s'agit d'un seul article.

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La quantité doit être au moins de 1.")]
        public int Quantite { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Le prix unitaire doit être positif.")]
        public decimal PrixUnitaire { get; set; }

        // Propriété calculée pour le total
        [NotMapped] // Indique que ce champ ne sera pas mappé dans la base de données.
        public decimal Total => Quantite * PrixUnitaire;

        [Required]
        [ForeignKey("Commande")]
        public String CommandeId { get; set; }
        public Commande Commande { get; set; } // Renommé pour plus de clarté.
    }
}
