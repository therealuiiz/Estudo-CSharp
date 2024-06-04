// See https://aka.ms/new-console-template for more information
Console.WriteLine("Definindo variáveis do tipo string e object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Isto é uma string";
valor = "Isto é uma string alterada";
valor = "teste";

Console.WriteLine(valor);


//StringBuilder (veremos nas próximas aulas)

object nota = 10;
object valor1 = 8.55;
object nome1 = "Mariana";
object ativa = true;
object letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();


//Tipo dynamic apesar de semelhante ao tipo object ele é util para quando
//precisamos utilizar Reflection (vide anotações notion)

dynamic nota2 = 10;
dynamic nome2 = "Nicole";
dynamic ativa2 = false;
dynamic letra2 = 'B';
dynamic valor2 = 10.55;

Console.WriteLine(nota2);
Console.WriteLine(nome2);
Console.WriteLine(ativa2);
Console.WriteLine(letra2);
Console.WriteLine(ativa2);

Console.Readline();









