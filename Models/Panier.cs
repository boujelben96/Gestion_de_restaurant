using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Gestion_de_restaurant.Data;
using Microsoft.AspNetCore.Identity;

namespace Gestion_de_restaurant.Models
{
    public class Panier
    {
        [Key]
        public int String { get; set; } // Simplification du nom de clé primaire.

        // Clé étrangère vers l'utilisateur
        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; } // Utilisation explicite d'une clé étrangère.
        public ApplicationUser User { get; set; } // Renommé pour indiquer une relation 1-to-1.

        // Articles du panier
        public List<LigneCommande> LignesCommande { get; set; } = new List<LigneCommande>(); // Initialisation de la liste.
    }
}
