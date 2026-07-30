using System;
using System.Linq;

class Bee
{
    public static void Main(string[] args)
    {
        int n, pos = 1;

        n = int.Parse(Console.ReadLine());

       int[] m = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int men = m[0];

        for (int i = 0; i < n; i++)
        {
            if (m[i] < men)
            {
                men = m[i];
                pos = i + 1;
            }
        }
        Console.WriteLine("{0}", pos);
    }
}