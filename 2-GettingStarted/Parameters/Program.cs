using Microsoft.AspNetCore.Mvc;
using Parameters;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

// Pøedstavit route parametry, query parametry, atributy FromRoute, FromQuery, FromHeader

app.MapGet("books/{isbn:int}", (int isbn) =>
{
    return Results.Ok();
});


// Ukázat FromBody konverzi z jsonu na objekt

//app.MapPost("books", ([FromBody]Book book) =>
//{
//    return Results.Created();
//});

//builder.Services.Configure<JsonOptions>(options =>
//{
//    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
//    options.JsonSerializerOptions.IncludeFields = true;
//});

// Vlastní pojmenování parametrù [FromQuery("Nazev")]


// Typování route parametrù
//app.MapGet("/todos/{id:int}", (int id) => "");
//app.MapGet("/todos/{text}", (string text) => "");
//app.MapGet("/posts/{slug:regex(^[a-z]+$)}", (string slug) => $"Post {slug}");


// Ukázka naètení z DI kontejeru
//app.MapGet("books", (int name, ILogger<Program> logger) =>
//{
//    return Results.Ok();
//});


app.Run();
