//using Gestion_de_restaurant.Models.Repository;
//using Gestion_de_restaurant.Models;

//namespace Gestion_de_restaurant.Models.Command
//{
//    public class PasserCommandeCommand : Icommande
//    {
//        private readonly Commande _commande;
//        private readonly ICommandeRepository _commandeRepository;
//        private readonly IArticleRepository _articleRepository;

//        public PasserCommandeCommand(
//            Commande commande,
//            ICommandeRepository commandeRepository,
//            IArticleRepository articleRepository)
//        {
//            _commande = commande;
//            _commandeRepository = commandeRepository;
//            _articleRepository = articleRepository;
//        }

//        public async Task<Commande> ExecuteAsync()
//        {
//            // Vérifier que tous les articles existent
//            foreach (var ligne in _commande.LignesCommande)
//            {
//                var article = await _articleRepository.GetArticleById(ligne.ArticleId);
//                if (article == null)
//                {
//                    throw new InvalidOperationException($"L'article avec l'ID {ligne.ArticleId} n'existe pas.");
//                }
//            }

//            // Ajouter la commande à la base de données
//            return await _commandeRepository.AddCommande(_commande);
//        }
//    }
//}
