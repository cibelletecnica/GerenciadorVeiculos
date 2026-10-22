using System;
using System.Windows.Forms;
using GerenciadorVeiculos.Dados;
using GerenciadorVeiculos.Modelos;

namespace GerenciadorVeiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Já deixa o Carro selecionado assim que a janela abre
            cmbTipo.SelectedIndex = 0;
        }

        // Quando o usuário muda entre Carro e Moto na lista suspensa
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem != null && cmbTipo.SelectedItem.ToString() == "Carro")
            {
                lblEspecifico.Text = "Portas:";
            }
            else
            {
                lblEspecifico.Text = "Cilindradas:";
            }
        }

        // Clique do botão Cadastrar Veículo
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Validação básica: verificar se algum campo ficou em branco
                if (txtModelo.Text == "" || txtDiaria.Text == "" || txtEspecifico.Text == "")
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Coletando os valores digitados na tela
                string modelo = txtModelo.Text;
                decimal diaria = Convert.ToDecimal(txtDiaria.Text);
                int especifico = Convert.ToInt32(txtEspecifico.Text);
                string tipo = cmbTipo.SelectedItem.ToString();

                Veiculo veiculo = null;

                // 3. Polimorfismo: instanciando Carro ou Moto
                if (tipo == "Carro")
                {
                    veiculo = new Carro(modelo, diaria, especifico);
                }
                else
                {
                    veiculo = new Moto(modelo, diaria, especifico);
                }

                // 4. Enviando para o banco de dados através do DAO
                VeiculoDAO dao = new VeiculoDAO();
                dao.Cadastrar(veiculo);

                // 5. Exibindo mensagem de confirmação
                decimal seguro = veiculo.CalcularSeguro();
                string mensagem = $"Veículo cadastrado com sucesso no banco de dados!\n\n" +
                                  $"Modelo: {veiculo.Modelo}\n" +
                                  $"Diária: R$ {veiculo.ValorDiaria:F2}\n" +
                                  $"Seguro calculado: R$ {seguro:F2}";

                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6. Limpando a tela para o próximo cadastro
                LimparCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Os campos de Diária e Portas/Cilindradas aceitam somente números.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clique do botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Função auxiliar simples para limpar os campos da tela
        private void LimparCampos()
        {
            txtModelo.Clear();
            txtDiaria.Clear();
            txtEspecifico.Clear();
            cmbTipo.SelectedIndex = 0;
            txtModelo.Focus();
        }

       
    }
}