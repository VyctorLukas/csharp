using System;

class Binary
{
    public static void Main ()
    {
        int x, y, res;
        float floatres;

        x = 7;
        y = 5;

        res = x + y;

        Console.WriteLine("X+Y: {0}\n", res);

        res = x - y;

        Console.WriteLine("X-Y: {0}\n", res);

        res = x * y;

        Console.WriteLine("X*Y: {0}\n", res);


        res = x / y;

        Console.WriteLine("X/Y: {0}\n", res);

        floatres = (float)x / (float)y;

        Console.WriteLine("X/Y: {0}\n", floatres);

        res = x % y;

        Console.WriteLine("X%Y: {0}\n", res);

        res += x;

        Console.WriteLine("res += X: {0}\n", res);


    }
}