using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Gestion_de_restaurant.Models;

namespace Gestion_de_restaurant.Data
{
    public class ApplicationUser : IdentityUser
    {
        // Panier de l'utilisateur
        public Panier Panier { get; set; } // Renommé pour indiquer qu'un utilisateur a un seul panier.

        // Commandes de l'utilisateur
        public List<Commande> Commandes { get; set; } = new List<Commande>(); // Initialisation de la liste.
    }
}
