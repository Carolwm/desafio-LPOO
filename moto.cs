class Moto : Veiculo {
    public void Acelerar(int Velocidade){
        this.Velocidade = Velocidade + 15;
    }

    public void Frear(int Velocidade){
        this.Velocidade = Velocidade - 10;
    }
}