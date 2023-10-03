int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [7, 8, 9];

int[] single = [..row0, ..row1, ..row2];
foreach (var element in single)
{
    Console.Write($"{element}, ");
}

Console.WriteLine("\n\n");


string[] name = ["o", "l"];
string[] surname = ["c", "z", "u"];

string[] email = [..surname, ..name, "a"];


foreach (var element in email)
{
    Console.Write($"{element}, ");
}

Console.ReadLine();