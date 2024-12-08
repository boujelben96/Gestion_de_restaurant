namespace Gestion_de_restaurant.Models
{
    public class ArticleCommande
    {
        public int Id { get; set; }
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }
        public int ArticleId { get; set; }
        public Articles Article { get; set; }
        public int Quantite { get; set; }
    }
}
