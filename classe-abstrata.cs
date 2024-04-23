using System;
public abstract class Cavalo
{
    private string especie;
    private string Nome;
    public Animal(string especie, string nome)
    {
        this. especie = especie;
        this.nome = nome;
    }
} 
public string GetEspecie() {
    return especie;
}
public void SetEspecie(string especie) {
    this.especie = especie;
}
public string GetNome() {
    return nome;
}
public void setetNome(string nome) {
    this.nome = nome;
} 
public abstract void EmitirSom();
public abstract void Galopar ();
public abstract class Cavalo {
    public abstract void come();
    public void Galopar(){
        Console.WriteLine($"{GatNome()} está galopando no pasto");
    }   
    public void Descansar(){
        Console.WriteLine($"{GatNome()} está descançando");
    }
}
public class Mamifero : Cavalo
{
    public Mamifero(string especie, string nome) : base (especie, nome)
    public override void EmitirSom()
    {
        Console.WriteLine($"{GetNome()} Rummmmm");
    }
    public override void Comer()
    {
        Console.WriteLine($"{GetNome} Esta comendo no pasto")
    }
}
public class Potros : Cavalo
{
        public Potros (string especie; string nome) : base (especie,nome){}
        public override void EmitirSom()
        {
            Console.WriteLine ($"{GetNome()} emitir som");
        }
        public override void Mamando()
        {
             Console.WriteLine ($"{GetNome()} esta mamando no pasto");

        }
}
public class Program {
    public static void Main(string[] args) {
        mamifero.Comer();
        mamifero.EmitirSom();
        mamifero.Galopar();
        mamifero.Descançar();

    Potros potros = new Potros ("Potros","bebes")
    potros.mamando();
    potros.Emitirsom();
    
    }
}
