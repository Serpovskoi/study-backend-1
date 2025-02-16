var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Включаем поддержку статических файлов
app.UseStaticFiles();

// Главная страница
//app.MapGet("/", () => Results.File("wwwroot/pages/index.html", "text/html"));
app.MapGet("/", async context =>{ await context.Response.SendFileAsync("wwwroot/pages/index.html"); });

// Дополнительные страницы
app.MapGet("/about", async context =>{ await context.Response.SendFileAsync("wwwroot/pages/about.html"); });
app.MapGet("/wikipedia", async context =>{ await context.Response.SendFileAsync("wwwroot/pages/wikipedia.html"); });
app.MapGet("/habr", async context =>{ await context.Response.SendFileAsync("wwwroot/pages/habr.html"); });

// Запускаем сервер
app.Run();
