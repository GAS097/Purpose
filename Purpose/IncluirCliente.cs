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

        //*Configurações da tela de inclusão de cliente
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ApenasNumeros(e);
        }

        private void IncluirCliente_Load(object sender, EventArgs e)
        {
            txtTelefone.MaxLength = 11;
            dtpDataDeNascimento.MaxDate = DateTime.Today;
        }
        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
        }
        private void txtTelefone_Click(object sender, EventArgs e)
        {
            txtTelefone.BackColor = Color.White;
        }

        //*Operações da tela de inclusão de clientes

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string validacao = string.Empty;

            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show(validacao = string.Format("O campo NOME está vazio, digite um nome.{0}", Environment.NewLine));
                txtNome.BackColor = Color.Red;
            }
            if (String.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show(validacao = string.Format("O campo TELEFONE está vazio, digite um telefone.{0}", Environment.NewLine));
                txtTelefone.BackColor = Color.Red;
            }
            if (txtTelefone.TextLength < 10)
            {
                MessageBox.Show(validacao = string.Format("Digite um número de telefone ou celular, com DDD.{0}", Environment.NewLine));
                txtTelefone.BackColor = Color.Red;
            }
            else
            {
                txtNome.BackColor = Color.White;
                txtTelefone.BackColor = Color.White;
                try
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                    stringSQL = new SqlConnection(connectionString);
                    scriptSQL = "INSERT INTO TB_CLIENTES (CLIENTE_NOME, CLIENTE_TELEFONE, CLIENTE_DATA_DE_NASCIMENTO) VALUES (@NOME, @TELEFONE, @DATADENASCIMENTO)";

                    comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                    comandoSQL.Parameters.AddWithValue("@NOME", txtNome.Text);
                    comandoSQL.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                    comandoSQL.Parameters.AddWithValue("@DATADENASCIMENTO", Convert.ToDateTime(dtpDataDeNascimento.Text));

                    stringSQL.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Cliente incluído com sucesso!");

                    stringSQL.Close();
                    stringSQL = null;
                    comandoSQL = null;

                    this.Close();
                }
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
