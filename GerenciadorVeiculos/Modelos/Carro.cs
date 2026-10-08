using System;

namespace GerenciadorVeiculos.Modelos
{
    // Os dois pontos (:) indicam que o Carro herda de Veiculo
    public class Carro : Veiculo
    {
        public int Portas { get; set; }
        public Carro(string modelo, decimal valorDiaria, int portas) : base(modelo, valorDiaria)
        {
            Portas = portas;
        }
        // Polimorfismo: para Carro, o seguro é 10% do valor da diária
        public override decimal CalcularSeguro()
        {
            return ValorDiaria * 0.1m;
        }
    }

}