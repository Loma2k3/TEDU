using AnimeShope.Data.EF;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
