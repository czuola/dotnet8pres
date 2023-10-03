using System.Net.Http.Json;
using System.Text.Json.Serialization;

var book = new Book(id: 42, "Title", "Author", publishedYear: 2023);
HttpContent content = JsonContent.Create(book, MyContext.Default.Book);

Console.WriteLine(await content.ReadAsStringAsync());
Console.ReadLine();

public record Book(int id, string title, string author, int publishedYear);


[JsonSerializable(typeof(Book))]
public partial class MyContext : JsonSerializerContext
{ }