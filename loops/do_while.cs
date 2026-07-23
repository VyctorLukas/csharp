using System;

class do_whily
{
    public static void Main()
    {
        string myChoice;

        do{
        //imprime o MENU
        Console.WriteLine("Meu livro de endereços\n");
        Console.WriteLine("A - Adicionar");
        Console.WriteLine("D - Deletar");
        Console.WriteLine("M - Modificar");
        Console.WriteLine("V - Visualizar");
        Console.WriteLine("S - Sair\n");
        Console.WriteLine("Choice (A,D,M,V, or S): ");

        //Obtém a escolha do usuário
        myChoice = Console.ReadLine();

            //Trata a escolha do usuário
            switch (myChoice)
            {
                case "A":
                case "a":
                Console.WriteLine("Você escolheu adicionar.");
                break;

                case "D":
                case "d":
                Console.WriteLine("Você escolheu deletar.");
                break;

                case "M":
                case "m":
                Console.WriteLine("Você escolheu modificar.");
                break;

                case "V":
                case "v":
                Console.WriteLine("Você escolheu visualizar.");
                break;

                case "S":
                case "s":
                Console.WriteLine("Tchau.");
                break;

                default:
                Console.WriteLine("{0} não é uma opção válida.", myChoice);
                break;
            }   

            //Dá uma pausa para permitir que o usuário veja o resultado
            Console.WriteLine("Pressione ENTER para continuar: ");
            Console.ReadLine();
            Console.WriteLine();

        }while(myChoice != "S" && myChoice != "s"); //Repete até o usuário digitar S/s

    }
}