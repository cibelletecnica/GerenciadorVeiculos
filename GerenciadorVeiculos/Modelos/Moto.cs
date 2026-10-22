using System;

namespace GerenciadorVeiculos.Modelos
{
    // Moto também herda de Veiculo
    public class Moto : Veiculo
    {
        // Informação exclusiva de motos
        public int Cilindradas { get; set; }

        public Moto(string modelo, decimal valorDiaria, int cilindradas)
            : base(modelo, valorDiaria)
        {
            Cilindradas = cilindradas;
        }

        // Polimorfismo: para Moto, o seguro é de 15% do valor da diária
        public override decimal CalcularSeguro()
        {
            return ValorDiaria * 0.15m;
        }
    }
}