// Подключаем пространство имен для работы с ASP.NET Core
var builder = WebApplication.CreateBuilder(args); // Создаем билдер приложения
var app = builder.Build(); // Собираем объект WebApplication

// Подключаем обработку статических файлов (нужно для HTML, CSS, JS и изображений в wwwroot)
app.UseStaticFiles();

// Главная страница
app.MapGet("/", async context =>{ await context.Response.SendFileAsync("wwwroot/pages/index.html"); });

// Дополнительные страницы
app.MapGet("/about", async context =>{ await context.Response.SendFileAsync("wwwroot/pages/about.html"); });
app.MapGet("/wikipedia", async context =>{ await context.Response.SendFileAsync("wwwroot/pages/wikipedia.html"); });
app.MapGet("/habr", async context =>{ await context.Response.SendFileAsync("wwwroot/pages/habr.html"); });

// Запускаем сервер
app.Run();
