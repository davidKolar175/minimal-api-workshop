namespace Validation;

public record Book
{
    public required string Isbn { get; init; }

    public required string Title { get; set; }

    public required string Author { get; set; }

    public required string ShortDescription { get; set; }

    public int PageCount { get; set; }

    public DateTime ReleaseDate { get; set; }
}

