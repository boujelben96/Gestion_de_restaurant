//using Gestion_de_restaurant.Data;
//using Microsoft.EntityFrameworkCore;

//namespace Gestion_de_restaurant.Models.Repository
//{
//    public class CommandeRepository : ICommandeRepository
//    {
//        private readonly RestaurantDbContext context;

//        public CommandeRepository(RestaurantDbContext context)
//        {
//            this.context = context;
//        }

//        public async Task<Commande> AddCommande(Commande commande)
//        {
//            var result = await context.Commandes.AddAsync(commande);
//            await context.SaveChangesAsync();
//            return result.Entity;
//        }

//        public async Task DeleteCommande(int id)
//        {
//            var commande = await context.Commandes.FindAsync(id);
//            context.Commandes.Remove(commande);
//            await context.SaveChangesAsync();
//        }

//        public async Task<List<Commande>> GetCommandes()
//        {
//            return await context.Commandes.ToListAsync();
//        }

//        public async Task<Commande> GetCommandeById(int id)
//        {
//            return await context.Commandes.FindAsync(id);
//        }

//        public async Task<List<Commande>> GetCommandesByName(string userName)
//        {
//            return await context.Commandes
//                .Include(c => c.User)
//                .Where(c => c.User.UserName == userName)
//                .ToListAsync();
//        }

//        public async Task<Commande> GetCommandeByName(string name)
//        {
//            return await context.Commandes
//                .Include(c => c.User)
//                .FirstOrDefaultAsync(c => c.User.UserName == name);
//        }

//        public async Task UpdateCommande(Commande commande)
//        {
//            context.Commandes.Update(commande);
//            await context.SaveChangesAsync();
//        }
//    }
//}

