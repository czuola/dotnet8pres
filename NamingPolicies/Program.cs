using System.Text.Json;

Console.WriteLine("Snake lower:");
var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };
Console.WriteLine(JsonSerializer.Serialize(new { PropertyName = "value" }, options));

Console.WriteLine("\nSnake upper:");
options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseUpper };
Console.WriteLine(JsonSerializer.Serialize(new { PropertyName = "value" }, options));

Console.WriteLine("\nKebab lower:");
options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.KebabCaseLower };
Console.WriteLine(JsonSerializer.Serialize(new { PropertyName = "value" }, options));

Console.WriteLine("\nKebab upper:");
options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.KebabCaseUpper };
Console.WriteLine(JsonSerializer.Serialize(new { PropertyName = "value" }, options));

Console.ReadLine();