namespace Gestion_de_restaurant.Models
{
    public class Panier
    {
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public ICollection<PanierItem> PanierItems { get; set; }
    }


}
