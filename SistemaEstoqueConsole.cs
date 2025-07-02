using SistemaEstoqueConsole.Models;

var products = new List<Product>();
int nextId = 1;
string? opt;

do
{
    Console.Clear();
    Console.WriteLine("=== SISTEMA DE ESTOQUE ===");
    Console.WriteLine("[1] Cadastrar produto");
    Console.WriteLine("[2] Listar produtos");
    Console.WriteLine("[3] Dar entrada/saída");
    Console.WriteLine("[4] Excluir produto");
    Console.WriteLine("[0] Sair");
    Console.Write("Opção: ");
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            Console.Write("Nome: ");
            var name = Console.ReadLine() ?? "";
            Console.Write("Quantidade inicial: ");
            int qty = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Preço unitário: ");
            decimal price = decimal.Parse(Console.ReadLine() ?? "0");
            products.Add(new Product { Id = nextId++, Name = name, Quantity = qty, UnitPrice = price });
            break;

        case "2":
            Console.WriteLine("\nID | Nome                 | Qtd  | Preço");
            products.ForEach(p => Console.WriteLine(p));
            Console.ReadKey();
            break;

        case "3": // ajustar estoque
            Console.Write("ID do produto: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            var prod = products.FirstOrDefault(p => p.Id == id);
            if (prod == null) break;
            Console.Write("Quantidade (+ ou -): ");
            int delta = int.Parse(Console.ReadLine() ?? "0");
            prod.Quantity += delta;
            break;

        case "4":
            Console.Write("ID do produto: ");
            int removeId = int.Parse(Console.ReadLine() ?? "0");
            products.RemoveAll(p => p.Id == removeId);
            break;
    }
} while (opt != "0");
