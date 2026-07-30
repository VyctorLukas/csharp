using System;

class Mjolnir
{
    public static void Main (string[] args)
    {
        string name;
        int strenght;
        int c = int.Parse(Console.ReadLine());

        for (int i = 0; i < c; i++)
        {
            string linha = Console.ReadLine();
            string [] partes = linha.Split(' ');

            name = partes[0];
            strenght = int.Parse(partes[1]);

            if (name == "Thor")
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
        }

    }
}