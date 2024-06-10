// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Nullable Types ##\n");

int valor = 100;
Console.WriteLine(valor);

//nulable types ou tipos anuláveis 
//Um nullable type é um tipo de valor que pode receber um valor null
//Os nullable types ou tipos anuláveis permitem atribuir um valor null a um tipo de valor
Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

//Nullable Types: declaração simplificada usando o operador '?'
//Para simplificar a declaração podemos usar o operador '?'

/* int? i =null;
double? d = null;
float? F = null;
bool? B = null; */

int? a2 = 1;
int b2 = a2 ?? 0;
Console.WriteLine(b2);

int? b3 = 100;
if (b3.HasValue)
{
    Console.WriteLine($"b3 = {b3.Value}");
}
else
{
    Console.WriteLine("b3 não possui um valor");
}


Console.ReadKey();

