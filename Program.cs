using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Veiculo> veiculos = new List<Veiculo>();

        veiculos.Add(new Carro());
        veiculos.Add(new Moto());

        foreach (var veiculo in veiculos)
        {
            veiculo.Acelerar();
            veiculo.ExibirVelocidade();
            veiculo.Frear();
            veiculo.ExibirVelocidade();
            
            Console.WriteLine(); 
        }

        Console.ReadLine();
    }
}