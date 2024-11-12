double primeiro, segundo;
Console.WriteLine("---Atividade Maior2Numero---\n");
Console.Write("Digite o primeiro numero: ");
primeiro = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo numero: ");
segundo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
if (primeiro > segundo){
    Console.WriteLine($"O maior numero entre os dois é: {primeiro}");
} else {
    Console.WriteLine($"O maior numero entre os dois é: {segundo}");
}