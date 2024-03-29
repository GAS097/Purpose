﻿
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
            pnTitulo = new System.Windows.Forms.Panel();
            btnMinimizar = new System.Windows.Forms.Button();
            btnMaximizar = new System.Windows.Forms.Button();
            btnFechar = new System.Windows.Forms.Button();
            lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tcClientes.SuspendLayout();
            tpClientes.SuspendLayout();
            tpReferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReferenciaClientes).BeginInit();
            pnTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSair.Image = Properties.Resources.icons8_emergency_exit_25;
            btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSair.Location = new System.Drawing.Point(410, 150);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(110, 30);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTelefone.Location = new System.Drawing.Point(82, 104);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Digite um número";
            txtTelefone.Size = new System.Drawing.Size(169, 22);
            txtTelefone.TabIndex = 2;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // lbDataDeNascimento
            // 
            lbDataDeNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbDataDeNascimento.AutoSize = true;
            lbDataDeNascimento.Location = new System.Drawing.Point(12, 156);
            lbDataDeNascimento.Name = "lbDataDeNascimento";
            lbDataDeNascimento.Size = new System.Drawing.Size(133, 16);
            lbDataDeNascimento.TabIndex = 27;
            lbDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // lbTelefone
            // 
            lbTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new System.Drawing.Point(12, 107);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new System.Drawing.Size(64, 16);
            lbTelefone.TabIndex = 26;
            lbTelefone.Text = "Telefone:";
            // 
            // dtpDataDeNascimento
            // 
            dtpDataDeNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDataDeNascimento.Location = new System.Drawing.Point(150, 151);
            dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            dtpDataDeNascimento.Size = new System.Drawing.Size(101, 22);
            dtpDataDeNascimento.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNome.Location = new System.Drawing.Point(62, 61);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite um nome";
            txtNome.Size = new System.Drawing.Size(317, 22);
            txtNome.TabIndex = 1;
            // 
            // btnIncluir
            // 
            btnIncluir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnIncluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnIncluir.Image = Properties.Resources.icons8_mais_2_matemática_32;
            btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnIncluir.Location = new System.Drawing.Point(12, 209);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new System.Drawing.Size(110, 30);
            btnIncluir.TabIndex = 7;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // lbNome
            // 
            lbNome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbNome.AutoSize = true;
            lbNome.Location = new System.Drawing.Point(12, 64);
            lbNome.Name = "lbNome";
            lbNome.Size = new System.Drawing.Size(47, 16);
            lbNome.TabIndex = 22;
            lbNome.Text = "Nome:";
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAlterar.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAlterar.Image = Properties.Resources.icons8_editar_24;
            btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAlterar.Location = new System.Drawing.Point(139, 209);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new System.Drawing.Size(110, 30);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnExcluir.Image = Properties.Resources.icons8_cancelar_24;
            btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnExcluir.Location = new System.Drawing.Point(267, 209);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(110, 30);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnFiltrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnFiltrar.Location = new System.Drawing.Point(410, 58);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new System.Drawing.Size(110, 30);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnExibir
            // 
            btnExibir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnExibir.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnExibir.Location = new System.Drawing.Point(410, 104);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new System.Drawing.Size(110, 30);
            btnExibir.TabIndex = 5;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = false;
            btnExibir.Click += btnExibir_Click;
            // 
            // lbFiltro
            // 
            lbFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbFiltro.AutoSize = true;
            lbFiltro.Location = new System.Drawing.Point(12, 259);
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
            tcClientes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tcClientes.Controls.Add(tpClientes);
            tcClientes.Controls.Add(tpReferencias);
            tcClientes.Location = new System.Drawing.Point(12, 278);
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
            // pnTitulo
            // 
            pnTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pnTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnTitulo.Controls.Add(btnMinimizar);
            pnTitulo.Controls.Add(btnMaximizar);
            pnTitulo.Controls.Add(btnFechar);
            pnTitulo.Controls.Add(lbTitulo);
            pnTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pnTitulo.Location = new System.Drawing.Point(-3, -1);
            pnTitulo.Name = "pnTitulo";
            pnTitulo.Size = new System.Drawing.Size(540, 43);
            pnTitulo.TabIndex = 38;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMinimizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnMinimizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnMinimizar.ForeColor = System.Drawing.Color.Black;
            btnMinimizar.Image = Properties.Resources.icons8_minimize_window_503;
            btnMinimizar.Location = new System.Drawing.Point(456, 3);
            btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new System.Drawing.Size(25, 30);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnMaximizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnMaximizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnMaximizar.ForeColor = System.Drawing.Color.Black;
            btnMaximizar.Image = Properties.Resources.icons8_maximizar_janela_502;
            btnMaximizar.Location = new System.Drawing.Point(481, 3);
            btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new System.Drawing.Size(25, 30);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnFechar.ForeColor = System.Drawing.Color.Black;
            btnFechar.Image = Properties.Resources.icons8_x_67__1_2;
            btnFechar.Location = new System.Drawing.Point(504, 3);
            btnFechar.Margin = new System.Windows.Forms.Padding(0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new System.Drawing.Size(25, 30);
            btnFechar.TabIndex = 1;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new System.Drawing.Point(195, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new System.Drawing.Size(183, 24);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Cadastro de Clientes";
            // 
            // CadastroDeClientes
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(533, 689);
            Controls.Add(pnTitulo);
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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "CadastroDeClientes";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += CadastroDeClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tcClientes.ResumeLayout(false);
            tpClientes.ResumeLayout(false);
            tpReferencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReferenciaClientes).EndInit();
            pnTitulo.ResumeLayout(false);
            pnTitulo.PerformLayout();
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
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.TabPage tpReferencias;
        public System.Windows.Forms.DataGridView dgvClientes;
        public System.Windows.Forms.DataGridView dgvReferenciaClientes;
        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        public System.Windows.Forms.TabControl tcClientes;
    }
}

