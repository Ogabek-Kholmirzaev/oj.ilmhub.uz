char ch = char.Parse(Console.ReadLine()!);

int n = (int)ch;

if(n >= 65 && n <= 90)
    Console.WriteLine((char)(n + 32));
else if (n >= 97 && n <= 122)
    Console.WriteLine((char)(n - 32));
else
    Console.WriteLine("none");