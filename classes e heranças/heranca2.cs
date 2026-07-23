using System;

//criação da classe Pessoa
public class Pessoa
{
    //atributos 
    public string nome;

    //construtor
    public Pessoa()
    {
        //não faz nada
    }

    //outro construtor
    public Pessoa (string n)
    {
        this.nome = n;
    }
}

//criando a classe pública Aluno, que herda os atributos da classe Pessoa.
public class Aluno : Pessoa
{
    //Adiciona outro atributo exclusivo dessa classe
    public string matricula;

    //Construtor com base na herança
    public Aluno(string m, string n) : base (n) /*A palavra-chave 'base' em C# é usada para acessar membros da classe base (classe pai) a partir da classe derivada.*/
    {
        this.matricula = m;
    }
}

//Classe para instanciar os objetos e mostrar os resultados 
class Exemplo
{
    public static void Main()
    {
        //Instanciando a classe Pessoa
        Pessoa pessoa = new Pessoa("Vyctor");
        Console.WriteLine("Nome: {0}.", pessoa.nome);

        //Instanciando a classe Aluno
        Aluno aluno = new Aluno("1234", "Bolsonaro");
        Console.WriteLine("Aluno com nome: {0}. Matricula: {1}.", aluno.nome, aluno.matricula);
    }
}