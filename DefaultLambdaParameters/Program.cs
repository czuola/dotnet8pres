var IncrementBy = (int startingValue, int increment = 1) => startingValue + increment;

Console.WriteLine("Default increment");
Console.WriteLine(IncrementBy(5)); // 6
Console.WriteLine("\nDefault increment overwritten by value 2");
Console.WriteLine(IncrementBy(5, 2)); // 7


//You can also declare lambda expressions with params arrays as parameters:

//var sum = (params int[] values) =>
//{
//    int sum = 10;
//    foreach (var value in values)
//        sum += value;

//    return sum;
//};

//var empty = sum();
//Console.WriteLine($"No sequence result: {empty}"); // 0

//var sequence = new[] { 1, 2, 3, 4, 5 };
//var total = sum(sequence);
//Console.WriteLine($"With sequence result: {total}"); // 15
//Console.ReadLine();
