class Carro : Veiculo {
    public void Acelerar(int Velocidade){
        this.Velocidade = Velocidade + 10;
    }

    public void Frear(int Velocidade){
        this.Velocidade = Velocidade - 5;
    }
}