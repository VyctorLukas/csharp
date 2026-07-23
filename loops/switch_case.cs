using System;

class switch_case
{
    public static void Main()
    {
        string myInput;
        int myInt;

        //Label begin
        begin:
            Console.WriteLine("Entre com um número entre 1 e 3: ");
            myInput = Console.ReadLine(); //ReadLine lê a entrada do usuário com uma string.
            myInt = Int32.Parse(myInput); //Parse converte myInput (string) em um inteiro.

        //Switch com o tipo inteiro
        switch (myInt)
        {
            case 1:
                    Console.WriteLine("seu número é {0}.", myInt);
                    break;
            case 2:
                    Console.WriteLine("seu número é {0}.", myInt);
                    break;
            case 3: 
                    Console.WriteLine("seu número é {0}.", myInt);
                    break;
            default:
                    Console.WriteLine("seu número {0} não está entre 1 e 3.", myInt);
                    break;        
        }

        //Label decide
        decide:
        Console.WriteLine("Digite \"continuar\" para continuar ou \"sair\" para sair: ");
        myInput = Console.ReadLine();

        //switch com tipo string
        switch (myInput)
        {
            case "continuar": 
                goto begin; //goto significa "go to". retorna a execução do programa para o label "begin".

            case "sair":
                Console.WriteLine("Tchau.");
                break;

            default: 
                Console.WriteLine("Sua entrada {0} está incorreta.", myInput);
                goto decide; //retorna a execução do programa para o label "decide".
        }
    }
}