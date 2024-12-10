namespace Gestion_de_restaurant.Models.Singleton
{
    public interface IMenu
    {
        List<Articles> GetMenu(); // Récupérer les articles du menu
        void AddArticle(Articles article); // Ajouter un article au menu
        void RemoveArticle(int articleId); // Supprimer un article du menu
        void ClearMenu(); // Réinitialiser le menu
    }

}
