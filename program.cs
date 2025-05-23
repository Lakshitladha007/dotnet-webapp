var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello, this is Lakshit's WebApp!");

app.Run();
