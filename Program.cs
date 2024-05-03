double primeiro, segundo;

Console.WriteLine("---Atividade Maior2Numero---");

Console.Write("Digite o primeiro numero:");
primeiro = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo numero:");
segundo = Convert.ToDouble(Console.ReadLine());

if (primeiro > segundo)
{
    Console.WriteLine($"O maior numero entre os dois é: {primeiro}");
}

else
{
    Console.WriteLine($"O maior numero entre os dois é: {segundo}");
}

