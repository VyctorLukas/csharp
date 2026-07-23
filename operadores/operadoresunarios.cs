using System;
class unario
{
public static void Main()
{
// Declaração das variáveis
int unario = 0;
int preIncremento;
int preDecremento;
int posIncremento;
int posDecremento;
int positivo;
int negativo;
sbyte bitNao;
bool logNao;
// Início do código
preIncremento = ++unario; 

Console.WriteLine("Pré incremento: {0}\n", preIncremento);
Console.WriteLine("Unário: {0}\n", unario);
Console.WriteLine(" ");

preDecremento = --unario;
Console.WriteLine("Pré decremento: {0}\n", preDecremento);
Console.WriteLine("Unário: {0}\n", unario);
Console.WriteLine(" ");

posDecremento = unario--;
Console.WriteLine("Pós decremento: {0}\n", posDecremento);
Console.WriteLine("Unário: {0}\n", unario);
Console.WriteLine(" ");

posIncremento = unario++;
Console.WriteLine("Pós-incremento: {0}\n", posIncremento);
Console.WriteLine("Unário: {0}\n", unario);
Console.WriteLine(" ");

Console.WriteLine("Valor final do Unário: {0}\n", unario);
Console.WriteLine(" ");

positivo = -posIncremento;
Console.WriteLine("Positivo: {0}\n", positivo);

negativo = +posIncremento;
Console.WriteLine("Negativo: {0}\n", negativo);
Console.WriteLine(" ");

bitNao = 0;
bitNao = (sbyte) (~bitNao); //o que esse "~" faz? É o bitwise. Ele inverte todos os bits do número: 0 vira 1 e 1 vira 0.

Console.WriteLine("Bitwise: {0}\n", bitNao);
Console.WriteLine(" ");

logNao = false;
logNao = !logNao; //"!" inverte o valor lógico da variável. LogNao agora é True.
Console.WriteLine("Não Lógico: {0}\n", logNao);
Console.WriteLine(" ");


}
}