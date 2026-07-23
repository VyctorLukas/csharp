/*Um outro conceito preliminar na POO (Programação Orientada a Objeto) é o polimorfismo. Sua
principal função é tornar possível criar métodos de mesmo nome em classes diferentes.*/

using System;

public class Ponto
{
    public virtual void desenhar() //'virtual' Permite que um método seja sobrescrito pelas classes filhas.
    {
        Console.WriteLine("Método 'desenhar' do objeto 'Ponto'");
    }
}

class Linha : Ponto
{
    public override void desenhar() //'override' Sobrescreve a implementação do método herdado.
    {
        Console.WriteLine("Método 'desenhar' do objeto 'Linha'");
        
    }
}

class Circulo : Linha
{
    public override void desenhar()
    {
        Console.WriteLine("Método 'desenhar' do objeto 'Circulo'");
    }
}

class Teste
{
    public static void Main()
    {
        //Instancia da classe Ponto
        Ponto ponto = new Ponto();
        ponto.desenhar();

        //Instancia da classe Linha
        Linha linha = new Linha();
        linha.desenhar();

        //Instancia da classe Circulo
        Circulo circulo = new Circulo();
        circulo.desenhar();
    }
}