using System.Net.Http.Json;

const string RequestUri = "https://api.contoso.com/books";
using var client = new HttpClient();

Console.WriteLine("\n\n\nOLD");

var booksOld = await client.GetFromJsonAsync<IEnumerable<Book>>(RequestUri);

foreach (var book in booksOld)
{
    Console.WriteLine($"Read book '{book.title}'");
}


Console.WriteLine("\n\n\n.NET 8");
using var client2 = new HttpClient();
var booksNew = client2.GetFromJsonAsAsyncEnumerable<Book>(RequestUri);

await foreach (var book in booksNew)
{
    Console.WriteLine($"Read book '{book.title}'");
}

Console.ReadLine();

public record Book(int id, string title, string author, int publishedYear);