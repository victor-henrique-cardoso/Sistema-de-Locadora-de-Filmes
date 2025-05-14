using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Cadastro de Endereço ===");
        Console.Write("Logradouro: ");
        string logradouro = Console.ReadLine()!;
        Console.Write("Número: ");
        string numero = Console.ReadLine()!;
        Console.Write("Bairro: ");
        string bairro = Console.ReadLine()!;
        Console.Write("Cidade: ");
        string cidade = Console.ReadLine()!;
        Console.Write("CEP: ");
        string cep = Console.ReadLine()!;

        Endereco endereco = new Endereco(logradouro, numero, bairro, cidade, cep);

        Console.WriteLine("\n=== Cadastro de Cliente ===");
        Console.Write("Nome completo: ");
        string nome = Console.ReadLine()!;
        Console.Write("CPF: ");
        string cpf = Console.ReadLine()!;
        Console.Write("Data de nascimento (dd/mm/aaaa): ");
        DateTime nascimento = DateTime.Parse(Console.ReadLine()!);
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine()!;

        Cliente cliente = new Cliente(nome, cpf, nascimento, telefone, endereco);

        Console.WriteLine("\n=== Cadastro de Filme ===");
        Console.Write("Título: ");
        string titulo = Console.ReadLine()!;
        Console.Write("Gênero: ");
        string genero = Console.ReadLine()!;
        Console.Write("Ano de Lançamento: ");
        int ano = int.Parse(Console.ReadLine()!);
        Console.Write("Diretor: ");
        string diretor = Console.ReadLine()!;
        Console.Write("Duração (minutos): ");
        int duracao = int.Parse(Console.ReadLine()!);

        Filme filme = new Filme(titulo, genero, ano, diretor, duracao);

        Console.WriteLine("\n=== Cadastro da Locação ===");
        DateTime dataLocacao = DateTime.Now;
        Console.Write("Data de devolução prevista (dd/mm/aaaa): ");
        DateTime dataDevolucao = DateTime.Parse(Console.ReadLine()!);
        Console.Write("Valor cobrado (R$): ");
        double valorCobrado = double.Parse(Console.ReadLine()!);

        Locacao locacao = new Locacao(cliente, filme, dataLocacao, dataDevolucao, valorCobrado);

        // Exibindo os dados cadastrados
        Console.Clear();
        Console.WriteLine("=== DADOS DA LOCAÇÃO ===\n");

        Console.WriteLine("Cliente: " + cliente.NomeCompleto);
        Console.WriteLine("CPF: " + cliente.CPF);
        Console.WriteLine("Data de Nascimento: " + cliente.DataNascimento.ToString("dd/MM/yyyy"));
        Console.WriteLine("Telefone: " + cliente.Telefone);
        Console.WriteLine("Endereço: " + cliente.EnderecoResidencial.Logradouro + ", " + cliente.EnderecoResidencial.Numero + " - " + cliente.EnderecoResidencial.Bairro + " - " + cliente.EnderecoResidencial.Cidade + " - " + cliente.EnderecoResidencial.CEP);

        Console.WriteLine("\nFilme Alugado: " + filme.Titulo);
        Console.WriteLine("Gênero: " + filme.Genero);
        Console.WriteLine("Ano de Lançamento: " + filme.AnoLancamento);
        Console.WriteLine("Diretor: " + filme.Diretor);
        Console.WriteLine("Duração: " + filme.DuracaoMinutos + " minutos");

        Console.WriteLine("\nLocação:");
        Console.WriteLine("Data de Locação: " + locacao.DataLocacao.ToString("dd/MM/yyyy"));
        Console.WriteLine("Data de Devolução: " + locacao.DataDevolucaoPrevista.ToString("dd/MM/yyyy"));
        Console.WriteLine("Valor Cobrado: R$" + locacao.ValorCobrado.ToString("F2"));

        Console.WriteLine("\n--- FIM ---");
    }
}
