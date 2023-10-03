ReadOnlySpan<string> buttons = new []
{
    "Red",
    "Yellow",
    "Green"
};

string[] thisRound = Random.Shared.GetItems(buttons, 10);

Console.WriteLine(string.Join("\n", thisRound));
Console.ReadLine();