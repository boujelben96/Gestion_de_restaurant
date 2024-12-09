using Microsoft.EntityFrameworkCore;
using Gestion_de_restaurant.Models.Repository;
using Gestion_de_restaurant.Models;
using System;
using Gestion_de_restaurant.Data;

namespace TP7.Models.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly RestaurantDbContext context;

        public ArticleRepository(RestaurantDbContext context)
        {
            this.context = context;
        }

        public async Task<Articles> AddArticle(Articles article)
        {
            var result = await context.Articles.AddAsync(article);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteArticle(int id)
        {
            var article = await context.Articles.FindAsync(id);
            context.Articles.Remove(article);
            await context.SaveChangesAsync();
        }

        public async Task<List<Articles>> GetArticles()
        {
            return await context.Articles.ToListAsync();
        }

        public async Task<Articles> GetArticleById(int id)
        {
            return await context.Articles.FindAsync(id);
        }

        public async Task<Articles> GetArticleByName(string name)
        {
            return await context.Articles.FirstOrDefaultAsync(a => a.Nom == name);
        }

        public async Task UpdateArticle(Articles article)
        {
            context.Articles.Update(article);
            await context.SaveChangesAsync();
        }
    }
}