public class Endereco
{
    private string logradouro, numero, bairro, cidade, cep;

    public string GetLogradouro() => logradouro;
    public void SetLogradouro(string valor) => logradouro = valor;

    public string GetNumero() => numero;
    public void SetNumero(string valor) => numero = valor;

    public string GetBairro() => bairro;
    public void SetBairro(string valor) => bairro = valor;

    public string GetCidade() => cidade;
    public void SetCidade(string valor) => cidade = valor;

    public string GetCEP() => cep;
    public void SetCEP(string valor) => cep = valor;

    public Endereco() { }

    public Endereco(string logradouro, string numero, string bairro, string cidade, string cep)
    {
        this.logradouro = logradouro;
        this.numero = numero;
        this.bairro = bairro;
        this.cidade = cidade;
        this.cep = cep;
    }
}
