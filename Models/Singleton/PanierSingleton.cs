//namespace Gestion_de_restaurant.Models.Singleton
//{
//    public class PanierSingleton : IPanier
//    {
//        private static PanierSingleton _instance;
//        public List<LigneCommande> Articles { get; private set; }

//        private PanierSingleton()
//        {
//            Articles = new List<LigneCommande>();
//        }

//        public static PanierSingleton Instance
//        {
//            get
//            {
//                if (_instance == null)
//                {
//                    _instance = new PanierSingleton();
//                }
//                return _instance;
//            }
//        }

//        public decimal Total => Articles.Sum(article => article.Total);

//        public void AjouterArticle(LigneCommande ligneCommande)
//        {
//            Articles.Add(ligneCommande);
//        }

//        public void SupprimerArticle(int articleId)
//        {
//            var article = Articles.FirstOrDefault(a => a.ArticleId == articleId);
//            if (article != null)
//            {
//                Articles.Remove(article);
//            }
//        }

//        public void ViderPanier()
//        {
//            Articles.Clear();
//        }
//    }
//}
