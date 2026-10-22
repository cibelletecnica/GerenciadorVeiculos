using MySql.Data.MySqlClient;
using GerenciadorVeiculos.Modelos;
using System;

namespace GerenciadorVeiculos.Dados
{
    public class VeiculoDAO
    {
        // Método responsável por fazer o Create (inserir no banco)
        public void Cadastrar(Veiculo veiculo)
        {
            string tipo = "";
            int dadoEspecifico = 0;

            // Verificamos se o veículo é um Carro ou uma Moto
            if (veiculo is Carro carro)
            {
                tipo = "Carro";
                dadoEspecifico = carro.Portas;
            }
            else if (veiculo is Moto moto)
            {
                tipo = "Moto";
                dadoEspecifico = moto.Cilindradas;
            }

            // Comando SQL seguro com parâmetros (@)
            string sql = "INSERT INTO veiculos (modelo, tipo, valor_diaria, valor_seguro, dado_especifico) " +
                         "VALUES (@modelo, @tipo, @valor_diaria, @valor_seguro, @dado_especifico);";

            // Abre a conexão, executa o comando e fecha automaticamente
            using (MySqlConnection conexao = ConexaoBD.ObterConexao())
            {
                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                    comando.Parameters.AddWithValue("@tipo", tipo);
                    comando.Parameters.AddWithValue("@valor_diaria", veiculo.ValorDiaria);
                    comando.Parameters.AddWithValue("@valor_seguro", veiculo.CalcularSeguro());
                    comando.Parameters.AddWithValue("@dado_especifico", dadoEspecifico);

                    // Executa a gravação no MySQL
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}