
namespace Purpose
{
    partial class AlterarCliente
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
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(359, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 27);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(82, 82);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(116, 22);
            this.txtTelefone.TabIndex = 20;
            // 
            // lbDataDeNascimento
            // 
            this.lbDataDeNascimento.AutoSize = true;
            this.lbDataDeNascimento.Location = new System.Drawing.Point(12, 128);
            this.lbDataDeNascimento.Name = "lbDataDeNascimento";
            this.lbDataDeNascimento.Size = new System.Drawing.Size(133, 16);
            this.lbDataDeNascimento.TabIndex = 19;
            this.lbDataDeNascimento.Text = "Data de Nascimento:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(12, 85);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(64, 16);
            this.lbTelefone.TabIndex = 18;
            this.lbTelefone.Text = "Telefone:";
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(151, 123);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(102, 22);
            this.dtpDataDeNascimento.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(271, 22);
            this.txtNome.TabIndex = 16;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(255, 190);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 27);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 41);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(47, 16);
            this.lbNome.TabIndex = 14;
            this.lbNome.Text = "Nome:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(23, 16);
            this.lbID.TabIndex = 22;
            this.lbID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(82, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(54, 22);
            this.txtID.TabIndex = 23;
            // 
            // AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 229);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbDataDeNascimento);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.dtpDataDeNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Cliente";
            this.Load += new System.EventHandler(this.AlterarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbDataDeNascimento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.TextBox txtTelefone;
        public System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbID;
        public System.Windows.Forms.TextBox txtID;
    }
}