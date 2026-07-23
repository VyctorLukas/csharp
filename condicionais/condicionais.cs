using System;

class condicionaL
{
    public static void Main()
    {
        string myInput;
        int myInt;
        Console.WriteLine("Entre com um número e pressione ENTER: ");
        myInput = Console.ReadLine();
        myInt = Int32.Parse(myInput); //A função Int32.Parse() converte uma string em um número inteiro do tipo int (Int32 é o nome completo do tipo int em C#).

        //Decisão simples com brackets
        if (myInt > 0)
        {
            Console.WriteLine("Seu número {0} é maior que 0.", myInt);
        }

        //Decisão simples sem brackets
        if (myInt < 0)
        {
            Console.WriteLine("Seu número {0} é menor que 0.", myInt);
        }

        //Decisão com "Senão"
        if (myInt != 0)
        {
            Console.WriteLine("Seu número {0} é diferente de 0.", myInt);
        }
        else
        {
            Console.WriteLine("Seu número {0} é igual a 0.", myInt);
        }

        //Múltipla decisão com E/OU

        if (myInt < 0 || myInt == 0) //Era só ter usado <=...
        {
            Console.WriteLine("Seu número {0} é menor ou igual a zero.", myInt);
        }

        else if (myInt > 0 && myInt <= 10)
        {
            Console.WriteLine("Seu número {0} está entre 1 e 10.", myInt);
        }
        
        else if (myInt > 10 && myInt <= 20)
        {
            Console.WriteLine("Seu número {0} está entre 11 e 20.", myInt);
        }
        else if (myInt > 20 && myInt <= 30)
        {
            Console.WriteLine("Seu número {0} está entre 21 e 30.", myInt); 
        }
        else
        {
            Console.WriteLine("Seu número {0} é maior que 30.", myInt);
        }

    }
}