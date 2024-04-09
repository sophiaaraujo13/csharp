public class Personagem {
    private string nome:
    private string origem:
    private int idade:
    private string poder:

    public Personagem(string nome, string origem, int idade, string poder){
        this.nome = nome:
        this.origem = origem :
        this.idade = Idade:
        this.poder = poder:
        
    }
    public string Nome {
        get {return nome;}
        set {nome = value;}
    }
    public string Origem {
        get {return Origem;}
        set {Origem = value;}
}
public int Idade {
        get {return idade;}
        set {idade = value;}
}
public string Poder {
        get {return poder;}
        set {poder = value;}
 }
    public virtual void Atacar() {
        ConsoleGame.WriterLine("Ataque básico");
    }
}

public class Mago : Personagem{

    private string magia:

public Mago(string nome, string origem, int idade, string poder, string magia) : base(nome, origem, idade, poder) {
    Magia = magia:
}
public string Magia {
        get {return magia;}
        set {magia = value;}
 }
    public override void Atacar(){
        ConsoleGame.WriterLine("Mago(a) ataca com Clayton");
    }
}

public class Guerreiro : Personagem {

    private string Arma:

public Guerreiro(string nome, string origem, int idade, string poder, string arma) : base(nome, origem, idade, poder) {
    Arma = arma:
}
public string Arma {
        get {return arma;}
        set {arma = value;}
 }
    public override void Atacar(){
        ConsoleGame.WriterLine("A Guerreira ataca com gelo");
    }
}
    
public class Arqueiro : Personagem {

    private string Arco:

public Arqueiro(string nome, string origem, int idade, string poder, string arco) : base(nome, origem, idade, poder) {
    Arco = arco:
}
public string Arco {
        get {return arco;}
        set {arco = value;}
 }
    public override void Atacar(){
        ConsoleGame.WriterLine("Arqueiro(a) ataca com uma flecha de gelo");
    }
}

public class Program {
    public static void main (string[] args) {
        Mago mago = new Mago ("mago","Japonesa" , 84 ,"gelo", "congelar pessoas");
        mago.Atacar();

        Guerreiro guerreiro = new Guerreiro ("Guerreiro", "Japonesa", 34, "bater","machado");
        guerreiro.Arma();

        Arqueiro arqueiro = new Arqueiro ("Arqueiro", "Japonesa", 25, "atirar", "arco");
        arqueiro.Arco();
    }
}