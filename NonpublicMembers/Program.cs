using System.Text.Json.Serialization;
using System.Text.Json;


var json = JsonSerializer.Serialize(new MySerializableNumber(33));
Console.WriteLine(JsonSerializer.Deserialize<MySerializableNumber>(json));
Console.WriteLine(json);

//json = JsonSerializer.Serialize(new MyPrivateNumber(44));

//Console.WriteLine(JsonSerializer.Deserialize<MyPrivateNumber>(json));
//Console.WriteLine(json);

//public class MyPrivateNumber
//{
//    internal MyPrivateNumber(int x) => X = x;

//    internal int X { get; }
//}

Console.ReadLine();


public class MySerializableNumber
{
    [JsonConstructor]
    internal MySerializableNumber(int x) => X = x;

    [JsonInclude]
    internal int X { get; }

    [JsonInclude]
    internal int Y { get; }
    internal int Z { get; }
}