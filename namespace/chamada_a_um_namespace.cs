using System;

namespace ns
{
    namespace mensagem
    {
        class alomundo
        {
            public static void alo()
            {
                Console.WriteLine("Alô, Mundo!");
            }
        }
    }

    class mandamensagem
    {
        public static void Main()
        {
            mensagem.alomundo.alo();  //se eu escrevesse using ns.mensagem, só precisaria escrever "alomundo.alo();".
        }
    }
}