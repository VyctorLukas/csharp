using System;
using mens = ns.mensagem.alomundo; //Aqui está o apelido/alias "mens"

namespace ns
{
    namespace mensagem
    {
        class alomundo
        {
            public static void Alo()
            {
                Console.WriteLine("Olá, Mundo!");
            }
        }
    }
}

class mandamensagem
{
    public static void Main()
    {
        mens.Alo();
    }
}