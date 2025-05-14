using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando objeto Endereco
        Endereco endereco = new Endereco("Rua das Flores", "123", "Centro", "São Paulo", "12345-678");

        // Criando objeto Cliente
        Cliente cliente = new Cliente("João Silva", "123.456.789-00", new DateTime(1990, 5, 15), "98765-4321", endereco);

        // Criando objeto Filme
        Filme filme = new Filme("Vingadores", "Ação", 2019, "Anthony Russo", 150);

        // Criando objeto Locacao
        Locacao locacao = new Locacao(cliente, filme, DateTime.Now, DateTime.Now.AddDays(7), 10.0);

        // Exibindo os dados cadastrados
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
        Console.WriteLine("Valor Cobrado: R$" + locacao.ValorCobrado);
    }
}
