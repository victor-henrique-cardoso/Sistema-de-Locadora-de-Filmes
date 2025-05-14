public class Locacao
{
    private Cliente clienteLocador;
    private Filme filmeAlugado;
    private DateTime dataLocacao, dataDevolucaoPrevista;
    private double valorCobrado;

    public Cliente GetClienteLocador() => clienteLocador;
    public void SetClienteLocador(Cliente valor) => clienteLocador = valor;

    public Filme GetFilmeAlugado() => filmeAlugado;
    public void SetFilmeAlugado(Filme valor) => filmeAlugado = valor;

    public DateTime GetDataLocacao() => dataLocacao;
    public void SetDataLocacao(DateTime valor) => dataLocacao = valor;

    public DateTime GetDataDevolucaoPrevista() => dataDevolucaoPrevista;
    public void SetDataDevolucaoPrevista(DateTime valor) => dataDevolucaoPrevista = valor;

    public double GetValorCobrado() => valorCobrado;
    public void SetValorCobrado(double valor) => valorCobrado = valor;

    public Locacao() { }

    public Locacao(Cliente clienteLocador, Filme filmeAlugado, DateTime dataLocacao, DateTime dataDevolucaoPrevista, double valorCobrado)
    {
        this.clienteLocador = clienteLocador;
        this.filmeAlugado = filmeAlugado;
        this.dataLocacao = dataLocacao;
        this.dataDevolucaoPrevista = dataDevolucaoPrevista;
        this.valorCobrado = valorCobrado;
    }
}
