using Gestion_de_restaurant.Data;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_restaurant.Models.Repository
{
    public class CammandeRepository
    {
        private readonly RestaurantDbContext context;

        public CammandeRepository(RestaurantDbContext context)
        {
            this.context = context;
        }

        public async Task<Commande> AddCommande(Commande commande)
        {
            var result = await context.Commandes.AddAsync(commande);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteCommande(int id)
        {
            var commande = await context.Commandes.FindAsync(id);
            context.Commandes.Remove(commande);
            await context.SaveChangesAsync();
        }

        public async Task<List<Commande>> GetCommandes()
        {
            return await context.Commandes.ToListAsync();
        }

        public async Task<Commande> GetCommandeById(int id)
        {
            return await context.Commandes.FindAsync(id);
        }
        public async Task<List<Commande>> GetCommandesByName(string userName)
        {
            return await context.Commandes
                .Include(c => c.Utilisateur)
                .Where(c => c.Utilisateur.Nom == userName)
                .ToListAsync();
        }
        //public async Task<Commande> GetCommandeByName(string name)
        //{
        //    return await context.Commandes.FirstOrDefaultAsync(Utilisateur => Utilisateur.Nom == name);
        //}

        public async Task UpdateCommande(Commande commande)
        {
            context.Commandes.Update(commande);
            await context.SaveChangesAsync();
        }
    }
}

