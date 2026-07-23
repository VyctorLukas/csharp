//Diretivas
using System;
using ns.mensagem;

//criando o namespace ns
namespace ns
{
    namespace mensagem
    {

        //criando a classe alomundo dentro do namespace mensagem
        class alomundo
        {
            public static void alo()
            {
                Console.WriteLine("Olá, mundo");

            }
        }
    }
}

class mandamensagem //Perceba que a classe mandamensagem fica fora do Namespace, e por isso
//é que faremos referencia a ele através do using no início do código.
{
    public static void Main()
    {
        alomundo.alo();
    }
}
