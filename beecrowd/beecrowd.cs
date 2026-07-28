using System;

class Bee
{
    public static void Main (string[] args)
    {
        string[] partes = Console.ReadLine().Split(' '); //dividindo o input em duas partes

        int a = int.Parse(partes[0]); //converter string para int
        int b = int.Parse(partes[1]);

        int q;
        int r;

        q = a/b;
        r = a%b;

        if (r < 0)
{
    if (b > 0)
    {
        q--;
        r += b;
    }
    else
    {
        q++;
        r -= b;
    }
}
        Console.WriteLine("{0} {1}\n", q, r);

    }
}