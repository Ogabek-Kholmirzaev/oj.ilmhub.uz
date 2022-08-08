string[] s = Console.ReadLine()!.Split(' ');

if (s[1] == "+")
    Console.WriteLine(int.Parse(s[0]) + int.Parse(s[2]));
else
    Console.WriteLine(int.Parse(s[0]) - int.Parse(s[2]));