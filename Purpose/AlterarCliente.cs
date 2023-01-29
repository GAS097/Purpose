using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Purpose
{
    public partial class AlterarCliente : Form
    {
        public AlterarCliente()
        {
            InitializeComponent();
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ApenasNumeros(e);
        }
        private void AlterarCliente_Load(object sender, EventArgs e)
        {

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
