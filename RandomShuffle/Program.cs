Span<string> buttons = new[]
{
    "Red",    
    "Red",
    "Yellow",
    "Yellow",
    "Green",
    "Green"
};

Random.Shared.Shuffle(buttons);

foreach(var button in buttons)
{
    Console.WriteLine(button);
}
Console.ReadLine();