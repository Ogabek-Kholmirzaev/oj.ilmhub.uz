double a = 0.0;
double b = 0.0;

a = Single.Parse(Console.ReadLine()!.Replace('.', ','));
b = Single.Parse(Console.ReadLine()!.Replace('.', ','));

Console.WriteLine($"Area is {String.Format("{0:0.00}", a * b)}.");