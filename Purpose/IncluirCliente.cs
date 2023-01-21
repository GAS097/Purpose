using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

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
            dtpDataDeNascimento.MaxDate = DateTime.Today;
        }       

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                stringSQL = new SqlConnection(connectionString);
                scriptSQL = "INSERT INTO TB_CLIENTES (NOME, TELEFONE, DATADENASCIMENTO) VALUES (@NOME, @TELEFONE, @DATADENASCIMENTO)";

                comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                comandoSQL.Parameters.AddWithValue("@NOME", txtNome.Text);
                comandoSQL.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comandoSQL.Parameters.AddWithValue("@DATADENASCIMENTO", dtpDataDeNascimento.Text);

                stringSQL.Open();

                if (String.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("O campo NOME está vazio, digite um nome.");
                }
                else if (String.IsNullOrWhiteSpace(txtTelefone.Text))
                {
                    MessageBox.Show("O campo TELEFONE está vazio, digite um telefone.");
                }
                else
                {
                    comandoSQL.ExecuteNonQuery();
                }
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

        private void dtpDataDeNascimento_ValueChanged(object sender, EventArgs e)
        {
            dtpDataDeNascimento.MaxDate = DateTime.Today;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {            
                Program.ApenasNumeros(e);
        }
    }
}
