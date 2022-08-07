int number = int.Parse(Console.ReadLine()!);

int soat = number / 3600;
number %= 3600;
int minut = number / 60;
int sekund = number % 60;

if (soat < 10)
    Console.Write("0");
Console.Write(soat + ":");

if (minut < 10)
    Console.Write("0");
Console.Write(minut + ":");

if (sekund < 10)
    Console.Write("0");
Console.Write(sekund);