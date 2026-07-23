using System;

class Aluno
{
    private string nome;
    public static void Main()
    {
        //Instanciando o objeto ALUNO
        Aluno aluno = new Aluno();

        //Executando o método setName para colocar nome no aluno
        aluno.setName("Carlos");

        //Escrevendo o nome do aluno no console usando o método getNome.
        Console.WriteLine(aluno.getName());
    }

    void setName(string n)
    {
        nome = n;
    }

    string getName()
    {
        return nome;
    }
}