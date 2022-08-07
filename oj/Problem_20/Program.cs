int number = int.Parse(Console.ReadLine()!);

if (number % 1000 >= 500)
    Console.WriteLine((number / 1000 + 1) * 1000);
else
    Console.WriteLine(number - number % 1000);