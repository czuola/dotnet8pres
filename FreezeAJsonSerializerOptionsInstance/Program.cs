using System.Text.Json;


var options = new JsonSerializerOptions();
options.TypeInfoResolver = 
options.MakeReadOnly();


Console.WriteLine($"Readonly: {options.IsReadOnly}");
Console.ReadLine();


options.DefaultBufferSize = 14;