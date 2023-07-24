namespace Data.Books;

using System;
using System.Collections.Generic;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public double AverageRating { get; set; }
}

public static class MockBookData
{
    public static List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Book 1",
                Author = "Author A",
                Description = "This is Book 1 description.",
                Price = 19.99,
                AverageRating = 4.5
            },
            new Book
            {
                Id = 2,
                Title = "Book 2",
                Author = "Author B",
                Description = "This is Book 2 description.",
                Price = 14.99,
                AverageRating = 4.2
            },
            new Book
            {
                Id = 3,
                Title = "Book 3",
                Author = "Author C",
                Description = "This is Book 3 description.",
                Price = 24.99,
                AverageRating = 4.8
            },
        };
    }
}
