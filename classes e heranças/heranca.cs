using System;

//criando a classe pessoa

public class Pessoa
{   
    public int idade;
    public string nome;

    //criando o construtor "Pessoa"
    public Pessoa()
    {
        Console.WriteLine("Foi criado um objeto Pessoa");
    }
}

//criando a classe "Aluno", que herda os atributos e métodos da classe "Pessoa"

public class Aluno : Pessoa //":" operador que marca a herança
{
    public string matricula;

    //criando o construtor Aluno
    public Aluno()
    {
        Console.WriteLine("Foi criado um objeto Aluno");
    }   
}

//iniciando a aplicação

class Inicio
{
    
public static void Main()
    {
        //Criando uma instância da classe Pessoa
        Pessoa pessoa = new Pessoa();
        pessoa.nome = "Vyctor";
        pessoa.idade = 19;

        Console.WriteLine("Nome: {0}. Idade: {1}", pessoa.nome, pessoa.idade);
        Console.WriteLine();

        //Criando uma instância da classe Aluno
        Aluno aluno = new Aluno();
        aluno.nome = "Bolsonaro";
        aluno.idade = 57;
        aluno.matricula = "1234";

        Console.WriteLine("Aluno: {0}. Idade: {1}. Matricula: {2}.", aluno.nome, aluno.idade, aluno.matricula);
        Console.WriteLine();

    }
    
}