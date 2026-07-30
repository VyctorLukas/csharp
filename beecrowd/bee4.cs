using System;

class Bee
{
    public static void Main(string[] args)
    {
        string kirk = "LIFE IS NOT A PROBLEM TO BE SOLVED";

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}", kirk[i]);
        }
    }
}