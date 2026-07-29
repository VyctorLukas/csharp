using System;
using System.Globalization;

class Bee
{
    
    public static void Main(string[] args)
    {
        string inputCorvo;
        int soma = 0;
        bool prog = true;

        while (prog == true){
        inputCorvo = Console.ReadLine();

        if (inputCorvo == null)
            {
                prog = false;
            }
        else if (inputCorvo == "caw caw")
            {
                Console.WriteLine("{0}", soma);
                soma = 0;
            }

        else 
        {
        if (inputCorvo[0] == '*')
            {
                soma += 4;
            }
        if (inputCorvo[1] == '*')
            {
                soma += 2;
            }
        if (inputCorvo[2] == '*')
            {
                soma += 1;
            }
        }
     }
  }
    
}        
    