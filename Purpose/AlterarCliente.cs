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
    public partial class AlterarCliente : Form
    {
        //*Declaração das variáveis de conexão, comando e script para executar no SQL

        SqlConnection stringSQL;
        SqlCommand comandoSQL;

        string scriptSQL;

        //*--------------------------------------------------------------------------
        
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
            txtTelefone.MaxLength = 11;
            dtpDataDeNascimento.MaxDate = DateTime.Today;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                stringSQL = new SqlConnection(connectionString);
                scriptSQL = "UPDATE TB_CLIENTES SET CLIENTE_NOME = @NOME, CLIENTE_TELEFONE = @TELEFONE, CLIENTE_DATA_DE_NASCIMENTO = @DATADENASCIMENTO WHERE CLIENTE_ID = @ID";

                comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                comandoSQL.Parameters.AddWithValue("@ID", txtID.Text);
                comandoSQL.Parameters.AddWithValue("@NOME", txtNome.Text);
                comandoSQL.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comandoSQL.Parameters.AddWithValue("@DATADENASCIMENTO", Convert.ToDateTime(dtpDataDeNascimento.Text));

                stringSQL.Open();
                comandoSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Cliente alterado com sucesso!");

                stringSQL.Close();
                stringSQL = null;
                comandoSQL = null;

                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
