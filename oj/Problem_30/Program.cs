﻿string[] str = Console.ReadLine()!.Split();

Console.WriteLine(Math.Max(int.Parse(str[0]), Math.Max(int.Parse(str[1]), int.Parse(str[2]))));