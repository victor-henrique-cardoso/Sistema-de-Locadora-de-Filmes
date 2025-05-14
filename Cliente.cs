public class Cliente
{
    private string nomeCompleto, cpf, telefone;
    private DateTime dataNascimento;
    private Endereco enderecoResidencial;

    public string GetNomeCompleto()
    {
        return this.nomeCompleto;
    }
    public void SetNomeCompleto(string valor)
    {
        this.nomeCompleto = valor;
    }

    public string GetCPF()
    {
        return this.cpf;
    }
    public void SetCPF(string valor)
    {
        this.cpf = valor;
    }

    public DateTime GetDataNascimento()
    {
        return this.dataNascimento;
    }
    public void SetDataNascimento(DateTime valor)
    {
        this.dataNascimento = valor;
    }

    public string GetTelefone()
    {
        return this.telefone;
    }
    public void SetTelefone(string valor)
    {
        this.telefone = valor;
    }

    public Endereco GetEnderecoResidencial()
    {
        return this.enderecoResidencial;
    }
    public void SetEnderecoResidencial(Endereco valor)
    {
        this.enderecoResidencial = valor;
    }

    public Cliente() { }

    public Cliente(string nomeCompleto, string cpf, DateTime dataNascimento, string telefone, Endereco endereco)
    {
        this.nomeCompleto = nomeCompleto;
        this.cpf = cpf;
        this.dataNascimento = dataNascimento;
        this.telefone = telefone;
        this.enderecoResidencial = endereco;
    }
}
