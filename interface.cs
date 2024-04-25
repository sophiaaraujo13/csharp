using System;

interface IAtacante {
    void Atacar();
}

public abstract class Heroi {
    private string nome;
    
    public Heroi(string nome) {
        this.nome = nome;
    }

    public string GetNome() {
        return nome;
    }

    public void SetNome(string nome) {
        this.nome = nome;
    }

    public abstract void Especial();
}

public class Guerreiro : Heroi, IAtacante {
    public Guerreiro(string nome) : base(nome) {}

    public void Atacar() {
        Console.WriteLine("Guerreiro está atacando");
    }

    public override void Especial() {
        Console.WriteLine("Guerreiro está usando seu ataque especial");
    }
}

public class Mago : Heroi, IAtacante {
    public Mago(string nome) : base(nome) {}

    public void Atacar() {
        Console.WriteLine("Mago está atacando");
    }

    public override void Especial() {
        Console.WriteLine("Mago está usando seu ataque especial");
    }
}

public class Arqueiro : Heroi, IAtacante {
    public Arqueiro(string nome) : base(nome) {}

    public void Atacar() {
        Console.WriteLine("Arqueiro está atacando");
    }

    public override void Especial() {
        Console.WriteLine("Arqueiro está usando seu ataque especial");
    }
}

public class Program {
    public static void Main(string[] args) {
        Guerreiro guerreiro = new Guerreiro("Corte de Vento");
        Mago mago = new Mago("Meteoro Flamejante");
        Arqueiro arqueiro = new Arqueiro("Rajada de Flechas");

        guerreiro.Atacar();
        guerreiro.Especial();

        mago.Atacar();
        mago.Especial();

        arqueiro.Atacar();
        arqueiro.Especial();
    }
}