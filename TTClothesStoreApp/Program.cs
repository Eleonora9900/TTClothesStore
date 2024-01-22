using TTClothesStore_BL.Interfaces;
using TTClothesStore_BL.Services;
using TTClothesStore_DL.Interfaces;
using TTClothesStore_DL.Repositories;

namespace TTClothesStoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IStoreRepository, StoreRepository>();
            builder.Services.AddSingleton<IItemRepository, ItemRepository>();

            builder.Services.AddSingleton<IItemService, ItemService>();
            builder.Services.AddSingleton<IStoreService, StoreService>();

            builder.Services.AddSingleton<IShoppingService, ShoppingService>();

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
        }
    }
}
