using System.Net.Security;

abstract class Veiculo {
    
    public int Velocidade { get; protected set; }

    public void Acelerar(){
        Console.WriteLine("acelerando");
    }

    public void Frear(){
        Console.WriteLine("freando");
    }

    public void ExibirVelocidade(){
        Console.WriteLine($"A velocidade atual é: {Velocidade} ");
    }
}
