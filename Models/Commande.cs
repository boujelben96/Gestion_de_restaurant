namespace Gestion_de_restaurant.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime DateCommande { get; set; }
        public decimal PrixTotal { get; set; }
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public ICollection<ArticleCommande> ArticlesCommande { get; set; }
    }
}
