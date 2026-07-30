using System;

class bee
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int hex = n.ToString("X");

        Console.WriteLine("{0}", hex);
    }
}