using FluentValidation;
using Validation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidatorsFromAssemblyContaining<Program>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapPost("book", (Book book, IValidator<Book> bookValidator) =>
{
    var validationResult =  bookValidator.Validate(book);

});


app.Run();
