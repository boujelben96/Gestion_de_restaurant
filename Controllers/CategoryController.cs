using Gestion_de_restaurant.Models;
using Gestion_de_restaurant.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestion_de_restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Categories> categories = await categoryRepository.GetCategories();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            Categories category = await categoryRepository.GetCategoryById(id);
            if (category == null)
                return NotFound();
            return Ok(category);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(Categories category)
        {
            Categories newCategory = await categoryRepository.AddCategory(category);
            if (newCategory == null)
                return BadRequest("Problem creating category");
            return CreatedAtAction(nameof(GetByID), new { id = newCategory.Id }, newCategory);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(Categories category)
        {
            await categoryRepository.UpdateCategory(category);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await categoryRepository.DeleteCategory(id);
            return NoContent();
        }
    }
}

