namespace GerenciadorVeiculos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtDiaria = new System.Windows.Forms.TextBox();
            this.txtEspecifico = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.lblEspecifico = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(68, 164);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 0;
            // 
            // txtDiaria
            // 
            this.txtDiaria.Location = new System.Drawing.Point(68, 209);
            this.txtDiaria.Name = "txtDiaria";
            this.txtDiaria.Size = new System.Drawing.Size(100, 20);
            this.txtDiaria.TabIndex = 1;
            // 
            // txtEspecifico
            // 
            this.txtEspecifico.Location = new System.Drawing.Point(111, 247);
            this.txtEspecifico.Name = "txtEspecifico";
            this.txtEspecifico.Size = new System.Drawing.Size(100, 20);
            this.txtEspecifico.TabIndex = 2;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.cmbTipo.Location = new System.Drawing.Point(68, 273);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 3;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(65, 148);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(83, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Digite o modelo:";
            // 
            // lblDiaria
            // 
            this.lblDiaria.AutoSize = true;
            this.lblDiaria.Location = new System.Drawing.Point(65, 193);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(115, 13);
            this.lblDiaria.TabIndex = 5;
            this.lblDiaria.Text = "Digite o valor da diária:";
            // 
            // lblEspecifico
            // 
            this.lblEspecifico.AutoSize = true;
            this.lblEspecifico.Location = new System.Drawing.Point(65, 250);
            this.lblEspecifico.Name = "lblEspecifico";
            this.lblEspecifico.Size = new System.Drawing.Size(40, 13);
            this.lblEspecifico.TabIndex = 6;
            this.lblEspecifico.Text = "Portas:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(68, 324);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Cadastrar Veículo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(68, 353);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblEspecifico);
            this.Controls.Add(this.lblDiaria);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtEspecifico);
            this.Controls.Add(this.txtDiaria);
            this.Controls.Add(this.txtModelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtDiaria;
        private System.Windows.Forms.TextBox txtEspecifico;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblDiaria;
        private System.Windows.Forms.Label lblEspecifico;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

