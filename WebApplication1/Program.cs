var builder = WebApplication.CreateBuilder(args);
builder.Environment.EnvironmentName = "1 lab 309.22210930";

var app = builder.Build();
app.MapGet("/", () => new Random().Next(1, 101));
app.Run();
