int n = int.Parse(Console.ReadLine()!);

if (n % 2 == 0 && n % 3 == 0 && n % 5 == 0)
    Console.WriteLine("A");
else if(n%2 == 0 && n % 3 == 0)
    Console.WriteLine("B");
else if(n%2 == 0 && n % 5 == 0)
    Console.WriteLine("C");
else if(n%3 == 0 && n % 5 == 0)
    Console.WriteLine("D");
else if(n%2 == 0 || n%3 == 0 || n % 5 == 0)
    Console.WriteLine("E");
else 
    Console.WriteLine("N");