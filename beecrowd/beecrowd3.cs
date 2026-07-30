using System;

class Bee
{
    public static void Main(string[] args)
    {
        string name1, name2;
        string pi1, pi2;
        int  soma, n1, n2;
        bool escolheupar1, escolheupar2;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
          soma = 0;  
          string [] linha = Console.ReadLine().Split(' ');

          name1 = linha[0];
          pi1 = linha[1];
          if(pi1 == "PAR")
            {
              escolheupar1 = true;  
            }
            else
            {
                escolheupar1 = false;
            }        

          name2 = linha[2];
          pi2 = linha[3];
          if (pi2 == "PAR")
            {
                escolheupar2 = true;
            }
            else
            {
                escolheupar2 = false;
            }

          string [] linha2 = Console.ReadLine().Split(' ');

          n1 = int.Parse(linha2[0]);
          n2 = int.Parse(linha2[1]);

          soma = n1 + n2;

          if(soma % 2 == 0 && escolheupar1 == true)
            {
                Console.WriteLine("{0}", name1);
            }
            else
            {
                Console.WriteLine("{0}", name2);
            }
            if(soma % 2 != 0 && escolheupar1 == false)
            {
                Console.Write("{0}", name1);
            }
            else
            {
                Console.WriteLine("{0}", name2);
            }
        }

    }
}