using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Purpose
{
    public partial class IncluirCliente : Form
    {
        SqlConnection stringSQL;
        SqlCommand comandoSQL;

        string scriptSQL;
        public IncluirCliente()
        {
            InitializeComponent();
        }

        private void IncluirCliente_Load(object sender, EventArgs e)
        {
            txtTelefone.MaxLength = 11;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                stringSQL = new SqlConnection("Server=localhost;Database=Purpose;User Id=sa;Password=sa123456;");
                scriptSQL = "INSERT INTO TB_CLIENTES (NOME, TELEFONE, DATADENASCIMENTO) VALUES (@NOME, @TELEFONE, @DATADENASCIMENTO)";

                comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                comandoSQL.Parameters.AddWithValue("@NOME", txtNome.Text);
                comandoSQL.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comandoSQL.Parameters.AddWithValue("@DATADENASCIMENTO", dtpDataDeNascimento.Text);

                stringSQL.Open();
                comandoSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Cliente incluído com sucesso!");                

                stringSQL.Close();
                stringSQL = null;
                comandoSQL = null;

                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
