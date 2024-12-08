namespace Gestion_de_restaurant.Models
{
    public class PanierItem
    {
        public int Id { get; set; }
        public int PanierId { get; set; }
        public Panier Panier { get; set; }
        public int ArticleId { get; set; }
        public Articles Article { get; set; }
        public int Quantite { get; set; }
    }
}
