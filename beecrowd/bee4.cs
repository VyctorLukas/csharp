using System;

class Bee
{
    public static void Main (string[] args)
    {
        int n;

        n = int.Parse(Console.ReadLine());

        int [] vet = new int [n];

        int min, pos = 0;

        vet[0] = int.Parse(Console.ReadLine());
        min = vet[0];

        for (int i = 1; i < n; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());

            if (vet[i] < min)
            {
                min = vet[i];
                pos = i + 1;
            }
        }

        Console.WriteLine("{0}", pos);
    }
}