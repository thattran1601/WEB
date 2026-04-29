var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Run($"http://0.0.0.0:{port}");
// 🔥 QUAN TRỌNG: phải có 2 dòng này
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapControllers();

app.Run();