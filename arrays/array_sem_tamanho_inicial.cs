using System;

class array
{
    public static void Main ()
    {
        string[] vetname = {"Ana", "Pedro", "Maria"};

        for (int x = 0; x <= 2; x++)
        {
            Console.WriteLine("Nome {0} = {1}\n", x, vetname[x]);
        }
    }
}