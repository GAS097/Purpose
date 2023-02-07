
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbDataDeNascimento = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(359, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(82, 66);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PlaceholderText = "Digite um número";
            this.txtTelefone.Size = new System.Drawing.Size(148, 22);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.Click += new System.EventHandler(this.txtTelefone_Click);
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // lbDataDeNascimento
            // 
            this.lbDataDeNascimento.AutoSize = true;
            this.lbDataDeNascimento.Location = new System.Drawing.Point(12, 112);
            this.lbDataDeNascimento.Name = "lbDataDeNascimento";
            this.lbDataDeNascimento.Size = new System.Drawing.Size(133, 16);
            this.lbDataDeNascimento.TabIndex = 19;
            this.lbDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(12, 69);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(64, 16);
            this.lbTelefone.TabIndex = 18;
            this.lbTelefone.Text = "Telefone:";
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(151, 107);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(103, 22);
            this.dtpDataDeNascimento.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Digite um nome";
            this.txtNome.Size = new System.Drawing.Size(371, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(255, 190);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 27);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 26);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(47, 16);
            this.lbNome.TabIndex = 14;
            this.lbNome.Text = "Nome:";
            // 
            // IncluirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 229);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbDataDeNascimento);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.dtpDataDeNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "IncluirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir Cliente";
            this.Load += new System.EventHandler(this.IncluirCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbDataDeNascimento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbNome;
    }
}