namespace Purpose
{
    partial class AlterarReferenciaDoCliente
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
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.cbbTipoDeReferencia = new System.Windows.Forms.ComboBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lbTipoDeReferencia = new System.Windows.Forms.Label();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDReferencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Location = new System.Drawing.Point(103, 15);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(83, 22);
            this.txtIDCliente.TabIndex = 42;
            // 
            // cbbTipoDeReferencia
            // 
            this.cbbTipoDeReferencia.FormattingEnabled = true;
            this.cbbTipoDeReferencia.Items.AddRange(new object[] {
            "Boa",
            "Ruim"});
            this.cbbTipoDeReferencia.Location = new System.Drawing.Point(162, 93);
            this.cbbTipoDeReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTipoDeReferencia.Name = "cbbTipoDeReferencia";
            this.cbbTipoDeReferencia.Size = new System.Drawing.Size(137, 24);
            this.cbbTipoDeReferencia.TabIndex = 33;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(28, 18);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(67, 16);
            this.lbID.TabIndex = 41;
            this.lbID.Text = "ID Cliente:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(490, 254);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 31);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(127, 139);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferencia.Multiline = true;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.PlaceholderText = "Escreva uma referência para este cliente:";
            this.txtReferencia.Size = new System.Drawing.Size(495, 95);
            this.txtReferencia.TabIndex = 34;
            this.txtReferencia.TextChanged += new System.EventHandler(this.txtReferencia_TextChanged);
            // 
            // lbTipoDeReferencia
            // 
            this.lbTipoDeReferencia.AutoSize = true;
            this.lbTipoDeReferencia.Location = new System.Drawing.Point(28, 96);
            this.lbTipoDeReferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipoDeReferencia.Name = "lbTipoDeReferencia";
            this.lbTipoDeReferencia.Size = new System.Drawing.Size(126, 16);
            this.lbTipoDeReferencia.TabIndex = 40;
            this.lbTipoDeReferencia.Text = "Tipo de Referência:";
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(28, 139);
            this.lbReferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(76, 16);
            this.lbReferencia.TabIndex = 39;
            this.lbReferencia.Text = "Referência:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(87, 54);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(311, 22);
            this.txtNomeCliente.TabIndex = 38;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(354, 254);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(128, 31);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(28, 57);
            this.lbCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(51, 16);
            this.lbCliente.TabIndex = 37;
            this.lbCliente.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID Referência:";
            // 
            // txtIDReferencia
            // 
            this.txtIDReferencia.Enabled = false;
            this.txtIDReferencia.Location = new System.Drawing.Point(296, 15);
            this.txtIDReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDReferencia.Name = "txtIDReferencia";
            this.txtIDReferencia.Size = new System.Drawing.Size(83, 22);
            this.txtIDReferencia.TabIndex = 44;
            // 
            // AlterarReferenciaDoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 298);
            this.Controls.Add(this.txtIDReferencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.cbbTipoDeReferencia);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.lbTipoDeReferencia);
            this.Controls.Add(this.lbReferencia);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlterarReferenciaDoCliente";
            this.Text = "AlterarReferenciaDoCliente";
            this.Load += new System.EventHandler(this.AlterarReferenciaDoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbTipoDeReferencia;
        private System.Windows.Forms.Label lbReferencia;
        public System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIDReferencia;
        public System.Windows.Forms.ComboBox cbbTipoDeReferencia;
        public System.Windows.Forms.TextBox txtReferencia;
    }
}