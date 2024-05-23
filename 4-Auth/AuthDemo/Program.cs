using FluentValidation;
using Library.Api.Auth;
using Library.Api.Data;
using Library.Api.Services;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(ApiKeySchemeConstants.SchemeName)
    .AddScheme<ApiKeyAuthSchemeOptions, ApiKeyAuthHandler>(ApiKeySchemeConstants.SchemeName, null);
builder.Services.AddAuthorization();

builder.Services.AddSingleton<IDbConnectionFactory>(_ =>
    new SqliteConnectionFactory(builder.Configuration.GetValue<string>("Database:ConnectionString")!));
builder.Services.AddSingleton<DatabaseInitializer>();
builder.Services.AddSingleton<IBookService, BookService>();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();

var app = builder.Build();

app.UseAuthorization();

app.MapGet("books",
    [Authorize(AuthenticationSchemes = ApiKeySchemeConstants.SchemeName)]
    async (IBookService bookService, string? searchTerm) =>
    {
        if (searchTerm is not null && !string.IsNullOrWhiteSpace(searchTerm))
        {
            var matchedBooks = await bookService.SearchByTitleAsync(searchTerm);
            return Results.Ok(matchedBooks);
        }

        var books = await bookService.GetAllAsync();
        return Results.Ok(books);
    });

var databaseInitializer = app.Services.GetRequiredService<DatabaseInitializer>();
await databaseInitializer.InitializeAsync();

app.Run();
