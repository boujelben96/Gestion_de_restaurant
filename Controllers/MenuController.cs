using Microsoft.AspNetCore.Mvc;
using Gestion_de_restaurant.Models.Repository;
using Gestion_de_restaurant.Models.Singleton;

[ApiController]
[Route("api/[controller]")]
public class MenuController : ControllerBase
{
    private readonly IArticleRepository _articleRepository;
    private readonly IMenu _menu;

    public MenuController(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
        _menu = MenuOfTheDay.GetInstance(); // Utilisation du Singleton
    }

    // Charger le menu avec une liste d'IDs
    [HttpPost("loadMenu")]
    public async Task<IActionResult> LoadMenu([FromBody] List<int> articleIds)
    {
        _menu.ClearMenu();

        foreach (var id in articleIds)
        {
            var article = await _articleRepository.GetArticleById(id);
            if (article != null)
            {
                _menu.AddArticle(article);
            }
        }

        return Ok("Menu chargé avec succès.");
    }

    // Récupérer tous les articles du menu
    [HttpGet]
    public IActionResult GetMenu()
    {
        var menu = _menu.GetMenu();
        if (menu == null || menu.Count == 0)
        {
            return NotFound("Le menu est vide.");
        }
        return Ok(menu);
    }

    // Ajouter un article au menu
    [HttpPost("addArticle")]
    public async Task<IActionResult> AddArticle([FromQuery] int articleId)
    {
        var article = await _articleRepository.GetArticleById(articleId);
        if (article == null)
        {
            return NotFound($"Aucun article trouvé avec l'ID {articleId}.");
        }

        _menu.AddArticle(article);
        return Ok("Article ajouté au menu.");
    }

    // Supprimer un article du menu
    [HttpDelete("removeArticle")]
    public IActionResult RemoveArticle([FromQuery] int articleId)
    {
        _menu.RemoveArticle(articleId);
        return Ok("Article retiré du menu.");
    }
}
