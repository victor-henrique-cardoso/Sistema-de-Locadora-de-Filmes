public class Endereco
{
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string CEP { get; set; }

    // Construtor padrão
    public Endereco() { }

    // Construtor parametrizado
    public Endereco(string logradouro, string numero, string bairro, string cidade, string cep)
    {
        Logradouro = logradouro;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        CEP = cep;
    }
}
