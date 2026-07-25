/* Interface é um contrato que declara membros sem implementação.
   Classes e structs podem implementá-la.
   Membros de interface são implicitamente públicos e não têm estado próprio.
   Interfaces servem para definir comportamento comum entre tipos diferentes. */

using System;

   //Criando interface
interface IInterFaceMae
{
    void MetodoMae();    
}

//Criando interface IMinhaInterface
interface IMinhaInterface : IInterFaceMae //Interface herdando interface
{
    void MeuMetodo();
}

//criando classe para usar as interfaces através de herança
class Componente : IMinhaInterface
{
    public void MeuMetodo(){
        Console.WriteLine("Método da interface IMinhaInterface foi chamado.");
    }

    public void MetodoMae(){
        Console.WriteLine("Método da interface MetodoMae foi chamado.");
    }
}

class Test {
    
    public static void Main(){
        Componente componente = new Componente();
        componente.MeuMetodo();
        componente.MetodoMae();
    }
}