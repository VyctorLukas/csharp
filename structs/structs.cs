/*Um strut permite que você crie propriedades do tipo similar aos tipos internos da classe.*/

using System;

struct Ponto
{
    public int x;
    public int y;

    //Construtor
    public Ponto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    //Método adicionar
    public Ponto Adicionar(Ponto ponto)
    {
        Ponto novoponto = new Ponto(0,0);
        novoponto.x = ponto.x + x;
        novoponto.y = ponto.y + y;

        return novoponto;
    }
}

class Exemplo
{
    public static void Main()
    {
        Ponto p1 = new Ponto(1,1);
        Ponto p2 = new Ponto(2,2); 
        Ponto p3;

        p3 = p1.Adicionar(p2);

        Console.WriteLine("p3 = {0},{1}", p3.x, p3.y);
    }
}