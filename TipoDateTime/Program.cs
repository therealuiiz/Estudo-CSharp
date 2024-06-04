﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//criar uma data específica usa formato: aaaa,mm,dd
DateTime dataHoje = new DateTime(2024, 06, 03);
Console.WriteLine(dataHoje);

//definir as horas
DateTime dataHoraHoje = new DateTime(2024, 09, 06, 21, 10, 30);
Console.WriteLine(dataHoraHoje);

Console.ReadKey();

DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje  :  {hoje}\n");


//extrair informações da data atual
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

//adicionando valores

Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));


//obter o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());


Console.ReadKey();

