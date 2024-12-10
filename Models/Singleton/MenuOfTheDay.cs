using Gestion_de_restaurant.Models;
using Gestion_de_restaurant.Models.Singleton;


public class MenuOfTheDay : IMenu
{
    private static MenuOfTheDay _instance;
    private static readonly object _lock = new object();

    private List<Articles> _articles;

    private MenuOfTheDay()
    {
        _articles = new List<Articles>();
    }

    public static MenuOfTheDay GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new MenuOfTheDay();
                }
            }
        }
        return _instance;
    }

    public List<Articles> GetMenu()
    {
        return _articles;
    }

    public void AddArticle(Articles article)
    {
        _articles.Add(article);
    }

    public void RemoveArticle(int articleId)
    {
        var article = _articles.FirstOrDefault(a => a.Id == articleId);
        if (article != null)
        {
            _articles.Remove(article);
        }
    }

    public void ClearMenu()
    {
        _articles.Clear();
    }
}
