
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
            btnSair = new System.Windows.Forms.Button();
            txtTelefone = new System.Windows.Forms.TextBox();
            lbDataDeNascimento = new System.Windows.Forms.Label();
            lbTelefone = new System.Windows.Forms.Label();
            dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            txtNome = new System.Windows.Forms.TextBox();
            btnIncluir = new System.Windows.Forms.Button();
            lbNome = new System.Windows.Forms.Label();
            btnAlterar = new System.Windows.Forms.Button();
            btnExcluir = new System.Windows.Forms.Button();
            btnFiltrar = new System.Windows.Forms.Button();
            btnExibir = new System.Windows.Forms.Button();
            lbFiltro = new System.Windows.Forms.Label();
            dgvClientes = new System.Windows.Forms.DataGridView();
            tcClientes = new System.Windows.Forms.TabControl();
            tpClientes = new System.Windows.Forms.TabPage();
            tpReferencias = new System.Windows.Forms.TabPage();
            dgvReferenciaClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tcClientes.SuspendLayout();
            tpClientes.SuspendLayout();
            tpReferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReferenciaClientes).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new System.Drawing.Point(410, 116);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(112, 29);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new System.Drawing.Point(82, 70);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Digite um número";
            txtTelefone.Size = new System.Drawing.Size(169, 22);
            txtTelefone.TabIndex = 2;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // lbDataDeNascimento
            // 
            lbDataDeNascimento.AutoSize = true;
            lbDataDeNascimento.Location = new System.Drawing.Point(12, 122);
            lbDataDeNascimento.Name = "lbDataDeNascimento";
            lbDataDeNascimento.Size = new System.Drawing.Size(133, 16);
            lbDataDeNascimento.TabIndex = 27;
            lbDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new System.Drawing.Point(12, 73);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new System.Drawing.Size(64, 16);
            lbTelefone.TabIndex = 26;
            lbTelefone.Text = "Telefone:";
            // 
            // dtpDataDeNascimento
            // 
            dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDataDeNascimento.Location = new System.Drawing.Point(150, 117);
            dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            dtpDataDeNascimento.Size = new System.Drawing.Size(101, 22);
            dtpDataDeNascimento.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new System.Drawing.Point(62, 27);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite um nome";
            txtNome.Size = new System.Drawing.Size(317, 22);
            txtNome.TabIndex = 1;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new System.Drawing.Point(12, 175);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new System.Drawing.Size(112, 29);
            btnIncluir.TabIndex = 7;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new System.Drawing.Point(12, 30);
            lbNome.Name = "lbNome";
            lbNome.Size = new System.Drawing.Size(47, 16);
            lbNome.TabIndex = 22;
            lbNome.Text = "Nome:";
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new System.Drawing.Point(139, 175);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new System.Drawing.Size(112, 29);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new System.Drawing.Point(267, 175);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(112, 29);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new System.Drawing.Point(410, 24);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new System.Drawing.Size(112, 29);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnExibir
            // 
            btnExibir.Location = new System.Drawing.Point(410, 70);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new System.Drawing.Size(112, 29);
            btnExibir.TabIndex = 5;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // lbFiltro
            // 
            lbFiltro.AutoSize = true;
            lbFiltro.Location = new System.Drawing.Point(12, 225);
            lbFiltro.Name = "lbFiltro";
            lbFiltro.Size = new System.Drawing.Size(39, 16);
            lbFiltro.TabIndex = 35;
            lbFiltro.Text = "Filtro:";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new System.Drawing.Point(3, 3);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new System.Drawing.Size(496, 364);
            dgvClientes.TabIndex = 36;
            // 
            // tcClientes
            // 
            tcClientes.Controls.Add(tpClientes);
            tcClientes.Controls.Add(tpReferencias);
            tcClientes.Location = new System.Drawing.Point(12, 244);
            tcClientes.Name = "tcClientes";
            tcClientes.SelectedIndex = 0;
            tcClientes.Size = new System.Drawing.Size(510, 399);
            tcClientes.TabIndex = 37;
            // 
            // tpClientes
            // 
            tpClientes.BackColor = System.Drawing.Color.Black;
            tpClientes.Controls.Add(dgvClientes);
            tpClientes.Location = new System.Drawing.Point(4, 25);
            tpClientes.Name = "tpClientes";
            tpClientes.Padding = new System.Windows.Forms.Padding(3);
            tpClientes.Size = new System.Drawing.Size(502, 370);
            tpClientes.TabIndex = 0;
            tpClientes.Text = "Clientes";
            // 
            // tpReferencias
            // 
            tpReferencias.BackColor = System.Drawing.Color.Black;
            tpReferencias.Controls.Add(dgvReferenciaClientes);
            tpReferencias.Location = new System.Drawing.Point(4, 25);
            tpReferencias.Name = "tpReferencias";
            tpReferencias.Padding = new System.Windows.Forms.Padding(3);
            tpReferencias.Size = new System.Drawing.Size(502, 370);
            tpReferencias.TabIndex = 1;
            tpReferencias.Text = "Referências";
            tpReferencias.Enter += tpReferencias_Enter;
            // 
            // dgvReferenciaClientes
            // 
            dgvReferenciaClientes.AllowUserToAddRows = false;
            dgvReferenciaClientes.AllowUserToDeleteRows = false;
            dgvReferenciaClientes.AllowUserToResizeRows = false;
            dgvReferenciaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReferenciaClientes.Location = new System.Drawing.Point(3, 3);
            dgvReferenciaClientes.Name = "dgvReferenciaClientes";
            dgvReferenciaClientes.RowTemplate.Height = 25;
            dgvReferenciaClientes.Size = new System.Drawing.Size(496, 364);
            dgvReferenciaClientes.TabIndex = 15;
            // 
            // CadastroDeClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(535, 655);
            Controls.Add(tcClientes);
            Controls.Add(lbFiltro);
            Controls.Add(btnExibir);
            Controls.Add(btnFiltrar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnSair);
            Controls.Add(txtTelefone);
            Controls.Add(lbDataDeNascimento);
            Controls.Add(lbTelefone);
            Controls.Add(dtpDataDeNascimento);
            Controls.Add(txtNome);
            Controls.Add(btnIncluir);
            Controls.Add(lbNome);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "CadastroDeClientes";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            Text = "Cadastro de Clientes";
            Load += CadastroDeClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tcClientes.ResumeLayout(false);
            tpClientes.ResumeLayout(false);
            tpReferencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReferenciaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TabControl tcClientes;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.TabPage tpReferencias;
        public System.Windows.Forms.DataGridView dgvClientes;
        public System.Windows.Forms.DataGridView dgvReferenciaClientes;
    }
}

