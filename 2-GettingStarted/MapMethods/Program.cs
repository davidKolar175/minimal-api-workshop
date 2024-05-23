using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.UseHttpsRedirection();

// Pøedstavit dùleité Map* metody, zmínit, co dìlá MapMethod

app.MapGet("", () =>
{
    return Results.Ok();
});


// Pøedstavit route parametry, query parametry, atributy FromRoute, FromQuery, FromHeader

app.MapGet("books/{isbn:int}", (int isbn) =>
{
    return Results.Ok();
});

app.Run();
