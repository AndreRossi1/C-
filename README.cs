using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Tabuada ===");
        Console.Write("Digite um número inteiro: ");

        // Tenta ler o número e verificar se é válido
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("\nTabuada do {numero}:\n");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine("{numero} x {i} = {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
