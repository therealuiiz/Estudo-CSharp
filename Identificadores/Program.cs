// See https://aka.ms/new-console-template for more information
Console.WriteLine("Definindo Identificadores");
Console.WriteLine();

//Identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//Identificadores inválidos
// int 5idade;
// int $valor;
// int valor#total;
// string nome Completo;

//para nomes de variáveis : camel case
string descontoTotal;
string desconto_Total;

//constantes: Maiúsculas
double PI = 3.14;
string PREFIXO = "11";
string PREFIXO_SP = "11";


Console.ReadLine();

//para nomes de classe e métodos: pascal case
class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Luiz");
    }
}
