using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


app.UseHttpsRedirection();

// P�edstavit d�le�it� Map* metody, zm�nit, co d�l� MapMethod

app.MapGet("", () =>
{
    return Results.Ok();
});


app.Run();
