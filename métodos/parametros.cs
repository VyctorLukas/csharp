using System;

class Sistema
{
    public static void Main (String[] args)
    {
        if (args.Length > 0)
            Console.WriteLine("Seja bem-vindo, {0}!", args[0]); //como a array "args"não tem nada, tive que colocar essa condicional pra aparecer alguma coisa. :P
        else
            Console.WriteLine("Seja bem-vindo!");
        
        Console.WriteLine("Este é o curso de C# por Carlos Vamberto");
    }
}