public class Filme
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int AnoLancamento { get; set; }
    public string Diretor { get; set; }
    public int DuracaoMinutos { get; set; }

    // Construtor padrão
    public Filme() { }

    // Construtor parametrizado
    public Filme(string titulo, string genero, int anoLancamento, string diretor, int duracaoMinutos)
    {
        Titulo = titulo;
        Genero = genero;
        AnoLancamento = anoLancamento;
        Diretor = diretor;
        DuracaoMinutos = duracaoMinutos;
    }
}
