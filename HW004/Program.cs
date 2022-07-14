// Задача №4

int a = new Random().Next(10,20);
int b = new Random().Next(10,20);
int c = new Random().Next(10,20);
int max = a;

Console.WriteLine(a + ", " + b + ", " + c);

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);