
namespace Purpose
{
    partial class CadastroDeClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbDataDeNascimento = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(410, 116);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 29);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(82, 70);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(169, 22);
            this.txtTelefone.TabIndex = 28;
            // 
            // lbDataDeNascimento
            // 
            this.lbDataDeNascimento.AutoSize = true;
            this.lbDataDeNascimento.Location = new System.Drawing.Point(12, 122);
            this.lbDataDeNascimento.Name = "lbDataDeNascimento";
            this.lbDataDeNascimento.Size = new System.Drawing.Size(133, 16);
            this.lbDataDeNascimento.TabIndex = 27;
            this.lbDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(12, 73);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(64, 16);
            this.lbTelefone.TabIndex = 26;
            this.lbTelefone.Text = "Telefone:";
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(150, 117);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(101, 22);
            this.dtpDataDeNascimento.TabIndex = 25;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(317, 22);
            this.txtNome.TabIndex = 24;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 175);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(112, 29);
            this.btnIncluir.TabIndex = 23;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 30);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(47, 16);
            this.lbNome.TabIndex = 22;
            this.lbNome.Text = "Nome:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(139, 175);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 29);
            this.btnAlterar.TabIndex = 31;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(267, 175);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 29);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(410, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 29);
            this.btnFiltrar.TabIndex = 33;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(410, 70);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(112, 29);
            this.btnExibir.TabIndex = 34;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(12, 225);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(36, 16);
            this.lbFiltro.TabIndex = 35;
            this.lbFiltro.Text = "Filtro";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 244);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(510, 150);
            this.dgvClientes.TabIndex = 36;
            // 
            // CadastroDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 406);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbDataDeNascimento);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.dtpDataDeNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lbNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CadastroDeClientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.CadastroDeClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbDataDeNascimento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}

