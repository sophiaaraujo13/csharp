public class Pessoa {
    private string nome;
    private int idade;
    private String cpf;

    public Pessoa(string nome, int idade, string cpf) {
        Nome = nome;
        idade = idade;
        CPF = cpf;
        }
        
    public string Nome {
        get { return nome;}
        set { nome = value;}
    }
    public int Idade{
        get { return idade;}
        get { idade = value;}
    }
    public string CPF {
        get { return cpf;}
        get { cpf = value;}
    }
}




