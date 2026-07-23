using System;

class for_each //neste comando de repetição, podemos varrer todos os elementos de um vetor, seja de objeto ou
//de tipos primitivos.
{
    public static void Main()
    {
        string [] name = {"Cheryl", "Joe", "Matt", "Robert"};

        foreach(string person in name)
        {
            Console.WriteLine("{0} ", person);
        }


    }
}