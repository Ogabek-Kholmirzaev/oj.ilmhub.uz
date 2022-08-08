int n = int.Parse(Console.ReadLine()!);

if((n%4 == 0 && n%100 != 0) || n%400 == 0)
    Console.WriteLine(1);
else
    Console.WriteLine(0);