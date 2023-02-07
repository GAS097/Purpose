
namespace Purpose
{
    partial class IncluirReferenciaDeCliente
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
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lbTipoDeReferencia = new System.Windows.Forms.Label();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.cbbTipoDeReferencia = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(435, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 29);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(114, 102);
            this.txtReferencia.Multiline = true;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.PlaceholderText = "Escreva uma referência para este cliente:";
            this.txtReferencia.Size = new System.Drawing.Size(433, 89);
            this.txtReferencia.TabIndex = 2;
            // 
            // lbTipoDeReferencia
            // 
            this.lbTipoDeReferencia.AutoSize = true;
            this.lbTipoDeReferencia.Location = new System.Drawing.Point(32, 70);
            this.lbTipoDeReferencia.Name = "lbTipoDeReferencia";
            this.lbTipoDeReferencia.Size = new System.Drawing.Size(126, 16);
            this.lbTipoDeReferencia.TabIndex = 27;
            this.lbTipoDeReferencia.Text = "Tipo de Referência:";
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(32, 102);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(76, 16);
            this.lbReferencia.TabIndex = 26;
            this.lbReferencia.Text = "Referência:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(85, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 22);
            this.txtNome.TabIndex = 24;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(317, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 29);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(32, 38);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(51, 16);
            this.lbCliente.TabIndex = 22;
            this.lbCliente.Text = "Cliente:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(32, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(23, 16);
            this.lbID.TabIndex = 30;
            this.lbID.Text = "ID:";
            // 
            // cbbTipoDeReferencia
            // 
            this.cbbTipoDeReferencia.FormattingEnabled = true;
            this.cbbTipoDeReferencia.Items.AddRange(new object[] {
            "Boa",
            "Ruim"});
            this.cbbTipoDeReferencia.Location = new System.Drawing.Point(164, 67);
            this.cbbTipoDeReferencia.Name = "cbbTipoDeReferencia";
            this.cbbTipoDeReferencia.Size = new System.Drawing.Size(121, 24);
            this.cbbTipoDeReferencia.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(85, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(73, 22);
            this.txtID.TabIndex = 32;
            // 
            // IncluirReferenciaDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 243);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cbbTipoDeReferencia);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.lbTipoDeReferencia);
            this.Controls.Add(this.lbReferencia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "IncluirReferenciaDeCliente";
            this.Text = "Incluir Referência de Cliente";
            this.Load += new System.EventHandler(this.CadastroDeReferenciasDeClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lbTipoDeReferencia;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cbbTipoDeReferencia;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtNome;
    }
}