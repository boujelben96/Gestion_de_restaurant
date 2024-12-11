using Gestion_de_restaurant.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_de_restaurant.Models
{
    public class Commande
    {
        [Key]
        public String Id { get; set; } // Simplification du nom de la clé primaire.

        [Required]
        public DateTime DateCommande { get; set; } // La date de commande est obligatoire.

        [Required]
        [ForeignKey("UserId")]
        public String UserId { get; set; } // Renommé pour plus de clarté.
        public ApplicationUser User { get; set; } // Relation avec ApplicationUser.

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Le prix total doit être positif.")]
        public decimal PrixTotal { get; set; } // Validation ajoutée.

        [Required]
        public StatutCommande Statut { get; set; } = StatutCommande.EnPreparation; // Valeur par défaut.

        public List<LigneCommande> LignesCommande { get; set; } = new List<LigneCommande>(); // Initialisation.
    }

    // Enumération pour les statuts de commande
    public enum StatutCommande
    {
        EnPreparation,  // Panier (avant validation)
        Validee,        // Commande validée par l'utilisateur
        EnCours,        // Commande en cours de traitement
        Annulee,        // Commande annulée par l'utilisateur ou l'administrateur
        Terminee        // Commande terminée ou livrée
    }
}
