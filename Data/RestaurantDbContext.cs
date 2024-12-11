using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Gestion_de_restaurant.Models;

namespace Gestion_de_restaurant.Data
{
    public class RestaurantDbContext : IdentityDbContext<ApplicationUser>
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) { }

        // Définir les DbSets pour chaque entité
        public DbSet<Article> Articles { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Menu> Menu { get; set; }  // Mise à jour pour le pluriel cohérent
        public DbSet<Panier> Paniers { get; set; }  // Garder le nom au pluriel
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<LigneCommande> LigneCommandes { get; set; }

        // Configuration des relations dans OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapper chaque entité à une table
            modelBuilder.Entity<Article>().ToTable("Article");
            modelBuilder.Entity<Categorie>().ToTable("Categorie");
            modelBuilder.Entity<Menu>().ToTable("Menu");  
            modelBuilder.Entity<Panier>().ToTable("Panier");
            modelBuilder.Entity<Commande>().ToTable("Commande");
            modelBuilder.Entity<LigneCommande>().ToTable("LignesCommande");

            // Relations entre les entités

            // Relation entre Menu et Articles (1:N)
            modelBuilder.Entity<Menu>()
                .HasMany(m => m.Articles)
                .WithOne(a => a.Menu)
                .HasForeignKey(a => a.Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Relation entre Category et Articles (1:N)
            modelBuilder.Entity<Categorie>()
                .HasMany(c => c.Articles)
                .WithOne(a => a.Categorie)
                .HasForeignKey(a => a.Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Relation entre Panier et Utilisateur (1:1)
            modelBuilder.Entity<Panier>()
                .HasOne(p => p.User)
                .WithOne(u => u.Panier)
                .HasForeignKey<Panier>(p => p.UserId) // Correction pour utiliser UserId
                .OnDelete(DeleteBehavior.Cascade);  // Si un utilisateur est supprimé, supprimer le panier

            // Relation entre Commande et Utilisateur (1:N)
            modelBuilder.Entity<Commande>()
                .HasOne(c => c.User)
                .WithMany(u => u.Commandes)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);  // Si un utilisateur est supprimé, supprimer les commandes

            // Relation entre Commande et LigneCommande (1:N)
            modelBuilder.Entity<Commande>()
                .HasMany(c => c.LignesCommande)
                .WithOne(lc => lc.Commande)
                .HasForeignKey(lc => lc.CommandeId)
                .OnDelete(DeleteBehavior.Cascade);  // Si une commande est supprimée, supprimer les lignes de commande

            // Relation entre LigneCommande et Article (N:1)
            modelBuilder.Entity<LigneCommande>()
                .HasOne(lc => lc.Article)
                .WithMany()
                .HasForeignKey(lc => lc.ArticleId)
                .OnDelete(DeleteBehavior.Cascade);  // Si un article est supprimé, supprimer les lignes de commande associées
        }
    }
}
