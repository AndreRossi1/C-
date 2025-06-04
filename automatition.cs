using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Caminho do arquivo de texto: ");
        string caminho = Console.ReadLine();

        Console.Write("Nome atual (a ser substituído): ");
        string nomeAntigo = Console.ReadLine();

        Console.Write("Novo nome (substituto): ");
        string nomeNovo = Console.ReadLine();

        try
        {
            if (!File.Exists(caminho))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return;
            }

            string conteudo = File.ReadAllText(caminho);
            conteudo = conteudo.Replace(nomeAntigo, nomeNovo);
            File.WriteAllText(caminho, conteudo);

            Console.WriteLine("Nome alterado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao processar: " + ex.Message);
        }
    }
}
