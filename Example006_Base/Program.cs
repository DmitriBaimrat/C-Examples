int a = new Random().Next(1, 10000);
System.Console.WriteLine(a);
int b = new Random().Next(1, 10000);
System.Console.WriteLine(b);
int c = new Random().Next(1, 10000);
System.Console.WriteLine(c);
int d = new Random().Next(1, 10000);
System.Console.WriteLine(d);
int e = new Random().Next(1, 10000);
System.Console.WriteLine(e);
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
System.Console.Write("max = ");
System.Console.WriteLine(max);
