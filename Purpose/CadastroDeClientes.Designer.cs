
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
            this.tcClientes = new System.Windows.Forms.TabControl();
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.tpReferencias = new System.Windows.Forms.TabPage();
            this.dgvReferenciaClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tcClientes.SuspendLayout();
            this.tpClientes.SuspendLayout();
            this.tpReferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferenciaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(410, 116);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 29);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(82, 70);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PlaceholderText = "Digite um número";
            this.txtTelefone.Size = new System.Drawing.Size(169, 22);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
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
            this.dtpDataDeNascimento.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Digite um nome";
            this.txtNome.Size = new System.Drawing.Size(317, 22);
            this.txtNome.TabIndex = 1;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 175);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(112, 29);
            this.btnIncluir.TabIndex = 7;
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
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(267, 175);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 29);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(410, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 29);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(410, 70);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(112, 29);
            this.btnExibir.TabIndex = 5;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(12, 225);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(39, 16);
            this.lbFiltro.TabIndex = 35;
            this.lbFiltro.Text = "Filtro:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(496, 364);
            this.dgvClientes.TabIndex = 36;
            // 
            // tcClientes
            // 
            this.tcClientes.Controls.Add(this.tpClientes);
            this.tcClientes.Controls.Add(this.tpReferencias);
            this.tcClientes.Location = new System.Drawing.Point(12, 244);
            this.tcClientes.Name = "tcClientes";
            this.tcClientes.SelectedIndex = 0;
            this.tcClientes.Size = new System.Drawing.Size(510, 399);
            this.tcClientes.TabIndex = 37;
            // 
            // tpClientes
            // 
            this.tpClientes.BackColor = System.Drawing.Color.Black;
            this.tpClientes.Controls.Add(this.dgvClientes);
            this.tpClientes.Location = new System.Drawing.Point(4, 25);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientes.Size = new System.Drawing.Size(502, 370);
            this.tpClientes.TabIndex = 0;
            this.tpClientes.Text = "Clientes";
            // 
            // tpReferencias
            // 
            this.tpReferencias.BackColor = System.Drawing.Color.Black;
            this.tpReferencias.Controls.Add(this.dgvReferenciaClientes);
            this.tpReferencias.Location = new System.Drawing.Point(4, 25);
            this.tpReferencias.Name = "tpReferencias";
            this.tpReferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpReferencias.Size = new System.Drawing.Size(502, 370);
            this.tpReferencias.TabIndex = 1;
            this.tpReferencias.Text = "Referências";
            this.tpReferencias.Enter += new System.EventHandler(this.tpReferencias_Enter);
            // 
            // dgvReferenciaClientes
            // 
            this.dgvReferenciaClientes.AllowUserToAddRows = false;
            this.dgvReferenciaClientes.AllowUserToDeleteRows = false;
            this.dgvReferenciaClientes.AllowUserToResizeRows = false;
            this.dgvReferenciaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReferenciaClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvReferenciaClientes.Name = "dgvReferenciaClientes";
            this.dgvReferenciaClientes.RowTemplate.Height = 25;
            this.dgvReferenciaClientes.Size = new System.Drawing.Size(496, 364);
            this.dgvReferenciaClientes.TabIndex = 15;
            // 
            // CadastroDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 655);
            this.Controls.Add(this.tcClientes);
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
            this.tcClientes.ResumeLayout(false);
            this.tpClientes.ResumeLayout(false);
            this.tpReferencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferenciaClientes)).EndInit();
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
        private System.Windows.Forms.TabControl tcClientes;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.TabPage tpReferencias;
        private System.Windows.Forms.DataGridView dgvReferenciaClientes;
    }
}

