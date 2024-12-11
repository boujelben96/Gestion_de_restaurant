//using Gestion_de_restaurant.Data;
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace Gestion_de_restaurant.Models.Repository
//{
//    public class CategoryRepository : ICategoryRepository
//    {
//        private readonly RestaurantDbContext context;

//        public CategoryRepository(RestaurantDbContext context)
//        {
//            this.context = context;
//        }

//        public async Task<Categories> AddCategory(Categories category)
//        {
//            var result = await context.Categories.AddAsync(category);
//            await context.SaveChangesAsync();
//            return result.Entity;
//        }

//        public async Task DeleteCategory(int id)
//        {
//            var category = await context.Categories.FindAsync(id);
//            context.Categories.Remove(category);
//            await context.SaveChangesAsync();
//        }

//        public async Task<List<Categories>> GetCategories()
//        {
//            return await context.Categories.ToListAsync();
//        }

//        public async Task<Categories> GetCategoryById(int id)
//        {
//            return await context.Categories.FindAsync(id);
//        }

//        public async Task<Categories> GetCategoryByName(string name)
//        {
//            return await context.Categories.FirstOrDefaultAsync(c => c.Name == name);
//        }

//        public async Task UpdateCategory(Categories category)
//        {
//            context.Categories.Update(category);
//            await context.SaveChangesAsync();
//        }
//    }
//}
