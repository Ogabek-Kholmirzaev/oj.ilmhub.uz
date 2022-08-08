string[] s = Console.ReadLine()!.Split();

int a = int.Parse(s[0]);
int b = int.Parse(s[1]);
int c = int.Parse(s[2]);

if((a*a + b*b == c*c) || (a*a + c*c == b*b) || (b*b+c*c == a*a))
    Console.WriteLine("true");
else
    Console.WriteLine("false");