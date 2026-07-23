using System;

class vetores
{
    public static void Main ()
    {
        //Declaração
        string[] vetName = new string[3];

        //atribuição
        vetName[0] = "Ana";
        vetName[1] = "Pedro";
        vetName[2] = "Maria";

        for (int x = 0; x <= 2; x++)
        {
            Console.WriteLine("Nome {0} = {1}\n", x, vetName[x]); //ao colocar mais uma variável no print, o "{0}" é acrescentado em mais 1, {1}.
        }

    }
}