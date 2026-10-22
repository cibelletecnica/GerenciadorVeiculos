using MySql.Data.MySqlClient;
using System;

namespace GerenciadorVeiculos.Dados
{
    public static class ConexaoBD
    {
        // Endereço do banco de dados no computador do laboratório
        private static string stringConexao = "Server=localhost;Database=locadora_db;Uid=root;Pwd=;";

        // Função que abre e entrega a conexão pronta para uso
        public static MySqlConnection ObterConexao()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(stringConexao);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar no MySQL: " + ex.Message);
            }
        }
    }
}