// Задача №8

double N = new Random().Next(10,20);
double a = 1;
Console.WriteLine("N = " + N);
while (a < N)
{
    if (a%2==0) Console.Write(a + ", ");
    a++;
}
Console.WriteLine("END");