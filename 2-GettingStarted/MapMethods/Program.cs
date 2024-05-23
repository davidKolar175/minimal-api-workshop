using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.UseHttpsRedirection();

// P�edstavit d�le�it� Map* metody, zm�nit, co d�l� MapMethod

app.MapGet("", () =>
{
    return Results.Ok();
});


// P�edstavit route parametry, query parametry, atributy FromRoute, FromQuery, FromHeader

app.MapGet("books/{isbn:int}", (int isbn) =>
{
    return Results.Ok();
});

app.Run();
