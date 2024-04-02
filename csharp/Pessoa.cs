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


public class Funcionario : Pessoa {
    private double salario:


    public double Bonus() {
        return salario * 0.1;
    }


    public Funcionario(string nome,int idade, string cpf, double salario) : base(nome, idade,cpf ){
        salario = salario;
    }


    public string Salario {
        get { return salario;}
        set { salario = value;}

    }
}

public class Diretor : Funcionario {
    

    public Diretor(string nome, int idade, string cpf, double salario) : base(nome, idade, cpf, salario){

    }


    public override double Bonus {
        return base.Bonus() + 1000;
    }
}