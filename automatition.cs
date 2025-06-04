using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Caminho do arquivo .txt: ");
        string caminho = Console.ReadLine();

        Console.Write("Digite um número para somar a cada número encontrado: ");
        if (!int.TryParse(Console.ReadLine(), out int incremento))
        {
            Console.WriteLine("Valor inválido.");
            return;
        }

        if (!File.Exists(caminho))
        {
            Console.WriteLine("Arquivo não encontrado.");
            return;
        }

        string conteudo = File.ReadAllText(caminho);

        // Regex para encontrar números inteiros
        string novoConteudo = Regex.Replace(conteudo, @"\d+", match =>
        {
            int numero = int.Parse(match.Value);
            return (numero + incremento).ToString();
        });

        File.WriteAllText(caminho, novoConteudo);
        Console.WriteLine("Números atualizados com sucesso!");
    }
}
