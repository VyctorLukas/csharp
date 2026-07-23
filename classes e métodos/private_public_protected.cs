using System;

class Aluno
{
    protected string nome;

    public void setNome(string n)
    {
        nome = n;
    }

    public string getNome()
    {
        return nome;
    }
    
    protected void delNome()
    {
        nome = "";
    }

    public void deleta()
    {
        this.delNome(); //O que é essa classe this? Representa a instância atual da classe
    }

}

class Metodo
{
    public static void Main()
    {
        //Instanciando o objeto ALUNO
        Aluno aluno = new Aluno();

        //Executando o método setNome para colocar o nome do Aluno
        aluno.setNome("Vyctor");

        //Escrevendo o nome do aluno no console usando o método getNome
        Console.WriteLine(aluno.getNome());

        //Excluir o conteúdo do nome
        aluno.deleta();

        //Escreve o nome deletado do aluno no console
        Console.WriteLine(aluno.getNome());

    }
}
/*
Perceba que os métodos da classe Aluno estão agora com a palavra reservada public no início.
Isto faz com que o método seja “enxergado” por outro método.

public - Métodos que permitem que outras classes possam acessá-los;

private - Métodos que inibe que outras classes possam acessá-los;

protected - Métodos que permitem que apenas a classe e as subclasses façam acesso a eles.
*/