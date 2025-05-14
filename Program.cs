using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("=== CADASTRO DE LOCAÇÃO DE FILMES ===\n");

        // Cadastro do Endereço
        Console.WriteLine(">>> CADASTRO DE ENDEREÇO <<<");
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

        // Cadastro do Cliente
        Console.WriteLine("\n>>> CADASTRO DE CLIENTE <<<");
        Console.Write("Nome completo: ");
        string nome = Console.ReadLine()!;
        Console.Write("CPF: ");
        string cpf = Console.ReadLine()!;
        Console.Write("Data de nascimento (dd/mm/aaaa): ");
        DateTime nascimento = DateTime.Parse(Console.ReadLine()!);
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine()!;

        Cliente cliente = new Cliente(nome, cpf, nascimento, telefone, endereco);

        // Cadastro do Filme
        Console.WriteLine("\n>>> CADASTRO DE FILME <<<");
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

        // Cadastro da Locação
        Console.WriteLine("\n>>> CADASTRO DA LOCAÇÃO <<<");
        DateTime dataLocacao = DateTime.Now;
        Console.Write("Data de devolução prevista (dd/mm/aaaa): ");
        DateTime dataDevolucao = DateTime.Parse(Console.ReadLine()!);
        Console.Write("Valor cobrado (R$): ");
        double valorCobrado = double.Parse(Console.ReadLine()!);

        Locacao locacao = new Locacao(cliente, filme, dataLocacao, dataDevolucao, valorCobrado);

        // Exibir os dados
        Console.Clear();
        Console.WriteLine("=== DADOS CADASTRADOS ===\n");

        Console.WriteLine(">>> CLIENTE");
        Console.WriteLine("Nome: " + cliente.GetNomeCompleto());
        Console.WriteLine("CPF: " + cliente.GetCPF());
        Console.WriteLine("Nascimento: " + cliente.GetDataNascimento().ToString("dd/MM/yyyy"));
        Console.WriteLine("Telefone: " + cliente.GetTelefone());

        Console.WriteLine("\n>>> ENDEREÇO");
        Console.WriteLine("Logradouro: " + endereco.GetLogradouro());
        Console.WriteLine("Número: " + endereco.GetNumero());
        Console.WriteLine("Bairro: " + endereco.GetBairro());
        Console.WriteLine("Cidade: " + endereco.GetCidade());
        Console.WriteLine("CEP: " + endereco.GetCEP());

        Console.WriteLine("\n>>> FILME");
        Console.WriteLine("Título: " + filme.GetTitulo());
        Console.WriteLine("Gênero: " + filme.GetGenero());
        Console.WriteLine("Ano de Lançamento: " + filme.GetAnoLancamento());
        Console.WriteLine("Diretor: " + filme.GetDiretor());
        Console.WriteLine("Duração: " + filme.GetDuracaoMinutos() + " minutos");

        Console.WriteLine("\n>>> LOCAÇÃO");
        Console.WriteLine("Data da Locação: " + locacao.GetDataLocacao().ToString("dd/MM/yyyy"));
        Console.WriteLine("Data de Devolução: " + locacao.GetDataDevolucaoPrevista().ToString("dd/MM/yyyy"));
        Console.WriteLine("Valor Cobrado: R$" + locacao.GetValorCobrado().ToString("F2"));

        Console.WriteLine("\n=== FIM DO CADASTRO ===");
    }
}
