int numeroDigitado;

Console.Write("Digite um número: ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

bool numeroEhPar = (numeroDigitado % 2) == 0;

if (numeroEhPar)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"{numeroDigitado} é par");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"{numeroDigitado} é ímpar");
}

Console.ResetColor();