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
            txtIDCliente = new System.Windows.Forms.TextBox();
            cbbTipoDeReferencia = new System.Windows.Forms.ComboBox();
            lbID = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            txtReferencia = new System.Windows.Forms.TextBox();
            lbTipoDeReferencia = new System.Windows.Forms.Label();
            lbReferencia = new System.Windows.Forms.Label();
            txtNomeCliente = new System.Windows.Forms.TextBox();
            btnSalvar = new System.Windows.Forms.Button();
            lbCliente = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtIDReferencia = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtIDCliente
            // 
            txtIDCliente.Enabled = false;
            txtIDCliente.Location = new System.Drawing.Point(103, 15);
            txtIDCliente.Margin = new System.Windows.Forms.Padding(4);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new System.Drawing.Size(83, 22);
            txtIDCliente.TabIndex = 42;
            // 
            // cbbTipoDeReferencia
            // 
            cbbTipoDeReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbTipoDeReferencia.FormattingEnabled = true;
            cbbTipoDeReferencia.Location = new System.Drawing.Point(162, 93);
            cbbTipoDeReferencia.Margin = new System.Windows.Forms.Padding(4);
            cbbTipoDeReferencia.Name = "cbbTipoDeReferencia";
            cbbTipoDeReferencia.Size = new System.Drawing.Size(137, 24);
            cbbTipoDeReferencia.TabIndex = 33;
            cbbTipoDeReferencia.Format += cbbTipoDeReferencia_Format;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new System.Drawing.Point(28, 18);
            lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbID.Name = "lbID";
            lbID.Size = new System.Drawing.Size(67, 16);
            lbID.TabIndex = 41;
            lbID.Text = "ID Cliente:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(490, 254);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(128, 31);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new System.Drawing.Point(103, 136);
            txtReferencia.Margin = new System.Windows.Forms.Padding(4);
            txtReferencia.Multiline = true;
            txtReferencia.Name = "txtReferencia";
            txtReferencia.PlaceholderText = "Escreva uma referência para este cliente:";
            txtReferencia.Size = new System.Drawing.Size(515, 95);
            txtReferencia.TabIndex = 34;
            txtReferencia.TextChanged += txtReferencia_TextChanged;
            // 
            // lbTipoDeReferencia
            // 
            lbTipoDeReferencia.AutoSize = true;
            lbTipoDeReferencia.Location = new System.Drawing.Point(28, 96);
            lbTipoDeReferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbTipoDeReferencia.Name = "lbTipoDeReferencia";
            lbTipoDeReferencia.Size = new System.Drawing.Size(126, 16);
            lbTipoDeReferencia.TabIndex = 40;
            lbTipoDeReferencia.Text = "Tipo de Referência:";
            // 
            // lbReferencia
            // 
            lbReferencia.AutoSize = true;
            lbReferencia.Location = new System.Drawing.Point(28, 139);
            lbReferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbReferencia.Name = "lbReferencia";
            lbReferencia.Size = new System.Drawing.Size(76, 16);
            lbReferencia.TabIndex = 39;
            lbReferencia.Text = "Referência:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Enabled = false;
            txtNomeCliente.Location = new System.Drawing.Point(103, 51);
            txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new System.Drawing.Size(311, 22);
            txtNomeCliente.TabIndex = 38;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new System.Drawing.Point(354, 254);
            btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(128, 31);
            btnSalvar.TabIndex = 35;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Location = new System.Drawing.Point(28, 57);
            lbCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new System.Drawing.Size(51, 16);
            lbCliente.TabIndex = 37;
            lbCliente.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(196, 18);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 16);
            label1.TabIndex = 43;
            label1.Text = "ID Referência:";
            // 
            // txtIDReferencia
            // 
            txtIDReferencia.Enabled = false;
            txtIDReferencia.Location = new System.Drawing.Point(296, 15);
            txtIDReferencia.Margin = new System.Windows.Forms.Padding(4);
            txtIDReferencia.Name = "txtIDReferencia";
            txtIDReferencia.Size = new System.Drawing.Size(83, 22);
            txtIDReferencia.TabIndex = 44;
            // 
            // AlterarReferenciaDoCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(635, 298);
            Controls.Add(txtIDReferencia);
            Controls.Add(label1);
            Controls.Add(txtIDCliente);
            Controls.Add(cbbTipoDeReferencia);
            Controls.Add(lbID);
            Controls.Add(btnCancelar);
            Controls.Add(txtReferencia);
            Controls.Add(lbTipoDeReferencia);
            Controls.Add(lbReferencia);
            Controls.Add(txtNomeCliente);
            Controls.Add(btnSalvar);
            Controls.Add(lbCliente);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "AlterarReferenciaDoCliente";
            Text = "AlterarReferenciaDoCliente";
            Load += AlterarReferenciaDoCliente_Load;
            ResumeLayout(false);
            PerformLayout();
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