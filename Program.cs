using Gestion_de_restaurant.Data;
using Gestion_de_restaurant.Models.Repository;
using Microsoft.EntityFrameworkCore;
using TP7.Models.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var cnx = builder.Configuration.GetConnectionString("connection");
builder.Services.AddDbContext<RestaurantDbContext>(options => options.UseSqlServer(cnx));


builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
//builder.Services.AddScoped<ICommandeRepository, CommandeRepository>();




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
