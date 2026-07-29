using System;

class Bee
{
    public static void Main(string[] args)
    {
        int a, b, c, aumA=0, aumB=0, desA=0, desB=0;

        string[] partes = Console.ReadLine().Split(' ');

        a = int.Parse(partes[0]);
        b = int.Parse(partes[1]);
        c = int.Parse(partes[2]);

        if (b > a)
        {
            aumA = b - a;
        }
        else
        {
            desA = a - b;
        }
        if (c > b)
        {
            aumB = c - b;
        }
        else
        {
            desB = b - c;
        }
if (b < a && c >= b)
{
    Console.WriteLine(":)");
}
else if (b > a && c <= b)
{
    Console.WriteLine(":(");
}
else if (b > a && c > b && aumB < aumA)
{
    Console.WriteLine(":(");
}
else if (b > a && c > b && aumB >= aumA)
{
    Console.WriteLine(":)");
}
else if (b < a && c < b && desB < desA)
{
    Console.WriteLine(":)");
}
else if (b < a && c < b && desB >= desA)
{
    Console.WriteLine(":(");
}
else if (b == a && c > b)
{
    Console.WriteLine(":)");
}
else
{
    Console.WriteLine(":(");
}
    }
}