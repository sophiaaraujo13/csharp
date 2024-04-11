public class Personagem {

    private string nome;
    private string origem;
    private int lv;
    public Personagem(string nome, string origem, int lv){
        this.nome = nome;
        this.origem = origem;
        this.lv = lv;
    }
    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public string origem {
        get { return origem; }
        set { raca = value; }
    }
    public int LV {
        get { return lv; }
        set { lv = value; }
    }
    public void Atacar() {
        Console.WriteLine("Ataque basico");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial:" + habilidade);
    }
}

public class Guerreiro: Personagem {
    private string arma;

    public Guerreiro(string nome; string origem; int lv; string arma;) : base(nome, origem, lv){
        Arma = arma;
    }

    public string Arma{
        get { return arma; }
        set { arma = value; }
    }
    public void Atacar() {
        Console.WriteLine("Slash!");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial do guerreiro:" + habilidade);
    }
}

public class Mago: Personagem {
    private string cajado magico;

    public Guerreiro(string nome; string origem; int lv; string cajado magico;) : base(nome, origem, lv){
        Cajado = cajado;
    }

    public string Cajado{
        get { return cajado; }
        set { cajado = value; }
    }
    public void Atacar() {
        Console.WriteLine("Fire Ball!");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial do mago:" + habilidade);
    }
}

public class Arqueiro: Personagem {
    private string arco;

    public Arqueiro(string nome; string origem; int lv; string arco;) : base(nome, origem, lv){
        Arco = arco;
    }

    public string Arco{
        get { return arco; }
        set { arco = value; }
    }
    public void Atacar() {
        Console.WriteLine("Arrowww!");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial do arqueiro:" + habilidade);
    }
}

pubic class Program {
    public static void main (string[] args) {
        Guerreiro guerreiro = new Guerreiro("Jade", "Japonesa", 34, "Machado de duas mãos");
        guerreiro.Atacar();
        guerreiro.Atacar("Golpe magico");

        Mago mago = new Mago("Mago", "Escolhido", 58, "Curador da morte");
        mago.Atacar();
        mago.Atacar("Jogar magia");

        Arqueiro arqueiro = new Arqueiro("Arqueiro", "Japonesa", 25, "Arco Magico lançado");
        arqueiro.Atacar();
        arqueiro.Atacar("Sangramento");
    }
}