public class Cliente
{
    public string NomeCompleto { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }
    public Endereco EnderecoResidencial { get; set; }

    // Construtor padrão
    public Cliente() { }

    // Construtor parametrizado
    public Cliente(string nomeCompleto, string cpf, DateTime dataNascimento, string telefone, Endereco endereco)
    {
        NomeCompleto = nomeCompleto;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Telefone = telefone;
        EnderecoResidencial = endereco;
    }
}
