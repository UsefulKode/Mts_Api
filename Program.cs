using Microsoft.EntityFrameworkCore; // Добавьте этот using вверху файла
using Mts_Api.Data; // Убедитесь, что это правильное пространство имен для вашего MtsDbContext.
                    // Оно должно соответствовать пространству имен, указанному в MtsDbContext.cs.
using Mts_Api.Models; // Добавьте, если нет, для моделей
using Mts_Api.Models.Profiles; 



namespace Mts_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Add services to the container.
            var builder = WebApplication.CreateBuilder(args);

            // Добавляем сервисы в контейнер.
            builder.Services.AddRazorPages(); // Или AddControllers, если у вас Web API / MVC

            // --- Добавляем DbContext ---
            builder.Services.AddDbContext<MtsDbContext>(options =>
                options.UseSqlServer("Server=46.182.132.89,1433;Database=MTS;User Id=sofa;Password=cjyz2605*;TrustServerCertificate=True;Encrypt=False;"));
            // -------------------------

            // --- Добавляем поддержку API-контроллеров ---
            builder.Services.AddControllers(); // ОЧЕНЬ ВАЖНО для работы ваших контроллеров!
                                               
            builder.Services.AddAutoMapper(typeof(Program));

            // --- Добавляем Swagger/OpenAPI ---
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // ---------------------------------

            var app = builder.Build();

            // Конфигурируем HTTP-конвейер запросов.
            if (app.Environment.IsDevelopment()) // Обычно Swagger включается только в режиме разработки
            {
                // --- Включаем Swagger UI ---
                app.UseSwagger();
                app.UseSwaggerUI();
                // --------------------------
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // --- Для маршрутизации API-контроллеров ---
            app.MapControllers(); // ОЧЕНЬ ВАЖНО для маршрутизации ваших контроллеров!
                                  // ---------------------------------------

            app.MapRazorPages(); // Или MapControllers, MapEndpoints, если это не Razor Pages

            app.Run();
        }
    }
}
