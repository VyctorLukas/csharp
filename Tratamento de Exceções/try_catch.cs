/*Sintaxe de Tratamento do uso do try...catch
Quando fazemos um tratamento de exceção, podemos tratar vários erros em apenas uma
estrutura. Os tratamentos mais ambíguos devem ficar entre os últimos e os mais específicos
devem ficar entre os primeiros. Vejamos um exemplo usando o System.IO.File:*/

using System;
using System.IO;
using System.Linq.Expressions; //Namespace para manipulação de arquivos e diretórios

class Exemplo
{

    public static void Main()
    {
        
    /*Se uma exceção ocorrer, 
    a execução do try é interrompida imediatamente e o programa passa para o catch.*/
    
    try
    {
        //Isto causará uma exceção
        File.OpenRead("\\teste\\ArquivoNaoExistente.txt");
    }
    catch (FileNotFoundException e) // Código executado caso ocorra uma exceção
    {
        Console.WriteLine();
        Console.WriteLine("Erro causado pelo FileNotFoundException");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(e.ToString());
        Console.WriteLine();    
    }
    catch (DirectoryNotFoundException e)
    {
        Console.WriteLine();
        Console.WriteLine("Erro causado pelo DirectoryNotFoundException");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(e.ToString());
        Console.WriteLine(); 
    }
    catch (Exception e)
    {
        Console.WriteLine();
        Console.WriteLine("Erro causado pelo Exception");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(e.ToString());
        Console.WriteLine(); 
    }
    finally // O finally é executado sempre, tenha ocorrido exceção ou não.
    {
        Console.WriteLine("Programa encerrado");
    }
}

    }