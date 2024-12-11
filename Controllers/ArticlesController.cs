//using Gestion_de_restaurant.Models;
//using Gestion_de_restaurant.Models.Repository;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace Gestion_de_restaurant.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ArticlesController : ControllerBase
//    {
//        private readonly IArticleRepository articleRepository;

//        public ArticlesController(IArticleRepository articleRepository)
//        {
//            this.articleRepository = articleRepository;
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetAll()
//        {
//            List<Articles> articles = await articleRepository.GetArticles();
//            return Ok(articles);
//        }

//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetByID(int id)
//        {
//            Articles article = await articleRepository.GetArticleById(id);
//            if (article == null)
//                return NotFound();
//            return Ok(article);
//        }
//        //get article by name
//        [HttpGet("{name}")]
//        public async Task<IActionResult> GetByName(string name)
//        {
//            Articles article = await articleRepository.GetArticleByName(name);
//            if (article == null)
//                return NotFound();
//            return Ok(article);
//        }

//        [HttpPost("create")]
//        public async Task<IActionResult> Create(Articles article)
//        {
//            Articles newArticle = await articleRepository.AddArticle(article);
//            if (newArticle == null)
//                return BadRequest("Problem creating article");
//            return CreatedAtAction(nameof(GetByID), new { id = newArticle.Id }, newArticle);
//        }

//        [HttpPut("update")]
//        public async Task<IActionResult> Update(Articles article)
//        {
//            await articleRepository.UpdateArticle(article);
//            return NoContent();
//        }

//        [HttpDelete("delete/{id}")]
//        public async Task<IActionResult> Delete(int id)
//        {
//            await articleRepository.DeleteArticle(id);
//            return NoContent();
//        }
//    }
//}
