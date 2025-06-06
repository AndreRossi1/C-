using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        // Dicionário com as regras do jogo
        var regras = new Dictionary<string, List<string>>
        {
            { "tesoura", new List<string> { "papel", "lagarto" } },
            { "papel", new List<string> { "pedra", "Spock" } },
            { "pedra", new List<string> { "lagarto", "tesoura" } },
            { "lagarto", new List<string> { "Spock", "papel" } },
            { "Spock", new List<string> { "tesoura", "pedra" } }
        };

        for (int i = 1; i <= T; i++)
        {
            string[] escolhas = Console.ReadLine().Split(' ');
            string sheldon = escolhas[0];
            string raj = escolhas[1];

            string resultado;

            if (sheldon == raj)
            {
                resultado = "De novo!";
            }
            else if (regras[sheldon].Contains(raj))
            {
                resultado = "Bazinga!";
            }
            else
            {
                resultado = "Raj trapaceou!";
            }

            Console.WriteLine($"Caso #{i}: {resultado}");
        }
    }
}
