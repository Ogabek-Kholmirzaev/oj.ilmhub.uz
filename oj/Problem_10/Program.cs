﻿int[] fib = new int[10];

fib[0] = 0;
fib[1] = 1;

for(int i = 2; i < fib.Length; i++) 
    fib[i] = fib[i - 1] + fib[i - 2];

for (int i = 0; i < fib.Length; i++) 
    Console.Write(fib[i] + " ");