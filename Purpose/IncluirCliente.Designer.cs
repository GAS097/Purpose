
namespace Purpose
{
    partial class IncluirCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelar = new System.Windows.Forms.Button();
            txtTelefone = new System.Windows.Forms.TextBox();
            lbDataDeNascimento = new System.Windows.Forms.Label();
            lbTelefone = new System.Windows.Forms.Label();
            dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            txtNome = new System.Windows.Forms.TextBox();
            btnSalvar = new System.Windows.Forms.Button();
            lbNome = new System.Windows.Forms.Label();
            lbCPF = new System.Windows.Forms.Label();
            txtCPF = new System.Windows.Forms.TextBox();
            btnConsultaCPF = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(359, 190);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(98, 27);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new System.Drawing.Point(82, 96);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Digite um número";
            txtTelefone.Size = new System.Drawing.Size(148, 22);
            txtTelefone.TabIndex = 2;
            txtTelefone.Click += txtTelefone_Click;
            txtTelefone.KeyPress += txtTelefone_KeyPress;
            // 
            // lbDataDeNascimento
            // 
            lbDataDeNascimento.AutoSize = true;
            lbDataDeNascimento.Location = new System.Drawing.Point(12, 142);
            lbDataDeNascimento.Name = "lbDataDeNascimento";
            lbDataDeNascimento.Size = new System.Drawing.Size(133, 16);
            lbDataDeNascimento.TabIndex = 19;
            lbDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new System.Drawing.Point(12, 99);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new System.Drawing.Size(64, 16);
            lbTelefone.TabIndex = 18;
            lbTelefone.Text = "Telefone:";
            // 
            // dtpDataDeNascimento
            // 
            dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDataDeNascimento.Location = new System.Drawing.Point(151, 137);
            dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            dtpDataDeNascimento.Size = new System.Drawing.Size(103, 22);
            dtpDataDeNascimento.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new System.Drawing.Point(65, 23);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Digite um nome";
            txtNome.Size = new System.Drawing.Size(371, 22);
            txtNome.TabIndex = 1;
            txtNome.Click += txtNome_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new System.Drawing.Point(255, 190);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(98, 27);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new System.Drawing.Point(12, 26);
            lbNome.Name = "lbNome";
            lbNome.Size = new System.Drawing.Size(47, 16);
            lbNome.TabIndex = 14;
            lbNome.Text = "Nome:";
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Location = new System.Drawing.Point(12, 64);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new System.Drawing.Size(36, 16);
            lbCPF.TabIndex = 20;
            lbCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new System.Drawing.Point(65, 61);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "Digite um CPF";
            txtCPF.Size = new System.Drawing.Size(148, 22);
            txtCPF.TabIndex = 21;
            txtCPF.Click += txtCPF_Click;
            // 
            // btnConsultaCPF
            // 
            btnConsultaCPF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnConsultaCPF.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnConsultaCPF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnConsultaCPF.Image = Properties.Resources.icons8_search_20;
            btnConsultaCPF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnConsultaCPF.Location = new System.Drawing.Point(219, 60);
            btnConsultaCPF.Name = "btnConsultaCPF";
            btnConsultaCPF.Size = new System.Drawing.Size(26, 23);
            btnConsultaCPF.TabIndex = 22;
            btnConsultaCPF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnConsultaCPF.UseVisualStyleBackColor = false;
            // 
            // IncluirCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(469, 229);
            Controls.Add(btnConsultaCPF);
            Controls.Add(txtCPF);
            Controls.Add(lbCPF);
            Controls.Add(btnCancelar);
            Controls.Add(txtTelefone);
            Controls.Add(lbDataDeNascimento);
            Controls.Add(lbTelefone);
            Controls.Add(dtpDataDeNascimento);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Controls.Add(lbNome);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "IncluirCliente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Incluir Cliente";
            Load += IncluirCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbDataDeNascimento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Button btnConsultaCPF;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCPF;
    }
}