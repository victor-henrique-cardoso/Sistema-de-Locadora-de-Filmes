public class Filme
{
    private string titulo, genero, diretor;
    private int anoLancamento, duracaoMinutos;

    public string GetTitulo() => titulo;
    public void SetTitulo(string valor) => titulo = valor;

    public string GetGenero() => genero;
    public void SetGenero(string valor) => genero = valor;

    public int GetAnoLancamento() => anoLancamento;
    public void SetAnoLancamento(int valor) => anoLancamento = valor;

    public string GetDiretor() => diretor;
    public void SetDiretor(string valor) => diretor = valor;

    public int GetDuracaoMinutos() => duracaoMinutos;
    public void SetDuracaoMinutos(int valor) => duracaoMinutos = valor;

    public Filme() { }

    public Filme(string titulo, string genero, int anoLancamento, string diretor, int duracaoMinutos)
    {
        this.titulo = titulo;
        this.genero = genero;
        this.anoLancamento = anoLancamento;
        this.diretor = diretor;
        this.duracaoMinutos = duracaoMinutos;
    }
}
