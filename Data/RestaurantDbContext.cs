using Gestion_de_restaurant.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_restaurant.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            : base(options) { }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Panier> Paniers { get; set; }
        public DbSet<PanierItem> PanierItems { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<ArticleCommande> ArticlesCommande { get; set; }


    }


}
