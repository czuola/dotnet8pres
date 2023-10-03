using System.Text.Json;

Console.WriteLine("Half, Int128, and UInt128 numeric types. serialization example:");
Console.WriteLine(JsonSerializer.Serialize(new object[]
{
    Half.MaxValue,
    Int128.MaxValue,
    UInt128.MaxValue
}));


Console.WriteLine("\n<ReadOnlyMemory<byte> serialization example (byte values are serialized to Base64 strings):");
Console.WriteLine(JsonSerializer.Serialize<ReadOnlyMemory<byte>>(new byte[] { 1, 2, 3 }));

Console.WriteLine("\nJsonSerializer.Serialize<Memory<int> example:");
Console.WriteLine(JsonSerializer.Serialize<Memory<int>>(new int[] { 1, 2, 3 }));
Console.ReadLine();