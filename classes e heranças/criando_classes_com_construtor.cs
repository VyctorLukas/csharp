using System;

class Aluno
{
    string nome;

//criando o método construtor
public Aluno(string n)
{
    nome = n;
}

//Método setName : coloca valor no atributo nome.
public void setName(string n)
{
    nome = n;
}

//Método getName : retorna o valor do atributo nome.
public string getName()
{
    return nome;
}

}
class exemplo
{
    public static void Main()
    {
        //Cria o objeto "alu", que é a instância da classe Aluno.
        Aluno alu = new Aluno("Vyctor");
        Console.WriteLine("Nome do aluno é: {0}", alu.getName());

        alu.setName("Vyctor2.0");
        Console.WriteLine("Nome do aluno agora é: {0}", alu.getName());
    }
}