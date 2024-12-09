namespace Gestion_de_restaurant.Models.Repository
{
    public interface ICategoryRepository
    {
        Task<List<Categories>> GetCategories();
        Task<Categories> AddCategory(Categories category);
        Task<Categories> GetCategoryById(int id);
        Task<Categories> GetCategoryByName(string name);
        Task UpdateCategory(Categories category);
        Task DeleteCategory(int id);


    }
}
