int a = 1, b = 8, c = 6, d = 2, e = 4;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine("max = " + max);