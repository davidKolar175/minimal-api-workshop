var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

var htmlResponse = """
    <html>
        <h1>Hello from HTML!</h1>
    </html>
""";


app.MapGet("test", () =>
{
    return Results.Ok(htmlResponse);
});



app.Run();
