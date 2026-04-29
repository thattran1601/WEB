var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

// 🔥 PHẢI đặt middleware TRƯỚC Run
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapControllers();

// 🔥 Render port
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Run($"http://0.0.0.0:{port}");