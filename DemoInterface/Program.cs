// See https://aka.ms/new-console-template for more information
using DemoInterface;

Console.WriteLine("Hello, World!");

BookService bookService = new BookService();
MovieService movieService = new MovieService();
int id = bookService.Add(new Book());
Guid id2 = movieService.Add(new Movie());