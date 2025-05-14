public class Locacao
{
    public Cliente ClienteLocador { get; set; }
    public Filme FilmeAlugado { get; set; }
    public DateTime DataLocacao { get; set; }
    public DateTime DataDevolucaoPrevista { get; set; }
    public double ValorCobrado { get; set; }

    // Construtor padrão
    public Locacao() { }

    // Construtor parametrizado
    public Locacao(Cliente clienteLocador, Filme filmeAlugado, DateTime dataLocacao, DateTime dataDevolucaoPrevista, double valorCobrado)
    {
        ClienteLocador = clienteLocador;
        FilmeAlugado = filmeAlugado;
        DataLocacao = dataLocacao;
        DataDevolucaoPrevista = dataDevolucaoPrevista;
        ValorCobrado = valorCobrado;
    }
}
