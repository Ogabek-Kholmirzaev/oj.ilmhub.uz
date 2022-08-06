string[] input = Console.ReadLine()!.Split(" ");

Console.Write("Birthday is ");

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length == 1) Console.Write("0");
    Console.Write(input[i]);

    if (i == 0) Console.Write("-");
    if (i == 1) Console.Write(".");
}