
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
            btnCancelar = new System.Windows.Forms.Button();
            txtReferencia = new System.Windows.Forms.TextBox();
            lbTipoDeReferencia = new System.Windows.Forms.Label();
            lbReferencia = new System.Windows.Forms.Label();
            txtNome = new System.Windows.Forms.TextBox();
            btnSalvar = new System.Windows.Forms.Button();
            lbCliente = new System.Windows.Forms.Label();
            lbID = new System.Windows.Forms.Label();
            cbbTipoDeReferencia = new System.Windows.Forms.ComboBox();
            txtID = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(435, 202);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(112, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new System.Drawing.Point(114, 102);
            txtReferencia.Multiline = true;
            txtReferencia.Name = "txtReferencia";
            txtReferencia.PlaceholderText = "Escreva uma referência para este cliente:";
            txtReferencia.Size = new System.Drawing.Size(433, 89);
            txtReferencia.TabIndex = 2;
            // 
            // lbTipoDeReferencia
            // 
            lbTipoDeReferencia.AutoSize = true;
            lbTipoDeReferencia.Location = new System.Drawing.Point(32, 70);
            lbTipoDeReferencia.Name = "lbTipoDeReferencia";
            lbTipoDeReferencia.Size = new System.Drawing.Size(126, 16);
            lbTipoDeReferencia.TabIndex = 27;
            lbTipoDeReferencia.Text = "Tipo de Referência:";
            // 
            // lbReferencia
            // 
            lbReferencia.AutoSize = true;
            lbReferencia.Location = new System.Drawing.Point(32, 102);
            lbReferencia.Name = "lbReferencia";
            lbReferencia.Size = new System.Drawing.Size(76, 16);
            lbReferencia.TabIndex = 26;
            lbReferencia.Text = "Referência:";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new System.Drawing.Point(85, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(272, 22);
            txtNome.TabIndex = 24;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new System.Drawing.Point(317, 202);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(112, 29);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Location = new System.Drawing.Point(32, 38);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new System.Drawing.Size(51, 16);
            lbCliente.TabIndex = 22;
            lbCliente.Text = "Cliente:";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new System.Drawing.Point(32, 9);
            lbID.Name = "lbID";
            lbID.Size = new System.Drawing.Size(23, 16);
            lbID.TabIndex = 30;
            lbID.Text = "ID:";
            // 
            // cbbTipoDeReferencia
            // 
            cbbTipoDeReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbTipoDeReferencia.FormattingEnabled = true;
            cbbTipoDeReferencia.Items.AddRange(new object[] { "Boa", "Ruim" });
            cbbTipoDeReferencia.Location = new System.Drawing.Point(164, 67);
            cbbTipoDeReferencia.Name = "cbbTipoDeReferencia";
            cbbTipoDeReferencia.Size = new System.Drawing.Size(121, 24);
            cbbTipoDeReferencia.TabIndex = 1;
            cbbTipoDeReferencia.Format += cbbTipoDeReferencia_Format;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new System.Drawing.Point(85, 6);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(73, 22);
            txtID.TabIndex = 32;
            // 
            // IncluirReferenciaDeCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(559, 243);
            Controls.Add(txtID);
            Controls.Add(cbbTipoDeReferencia);
            Controls.Add(lbID);
            Controls.Add(btnCancelar);
            Controls.Add(txtReferencia);
            Controls.Add(lbTipoDeReferencia);
            Controls.Add(lbReferencia);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Controls.Add(lbCliente);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "IncluirReferenciaDeCliente";
            Text = "Incluir Referência de Cliente";
            Load += IncluirReferenciaDeCliente_Load;
            ResumeLayout(false);
            PerformLayout();
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