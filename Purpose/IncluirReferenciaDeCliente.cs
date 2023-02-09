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
    public partial class IncluirReferenciaDeCliente : Form
    {
        SqlConnection stringSQL;
        SqlCommand comandoSQL;

        string scriptSQL;
        public IncluirReferenciaDeCliente()
        {
            InitializeComponent();
        }

        private void CadastroDeReferenciasDeClientes_Load(object sender, EventArgs e)
        {

        }       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string validacao = string.Empty;

            /*
            if (cbbTipoDeReferencia == null)
            {
                MessageBox.Show(validacao = string.Format("Selecione um tipo de referência para este cliente.{0}", Environment.NewLine));
                cbbTipoDeReferencia.BackColor = Color.Red;
            }
            */
            if (txtReferencia.TextLength < 20)
            {
                MessageBox.Show(validacao = string.Format("Digite uma referência com pelo menos 20 caracteres.{0}", Environment.NewLine));
            }            
            else
            {
                try
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                    stringSQL = new SqlConnection(connectionString);
                    scriptSQL = "INSERT INTO TB_CLIENTES_REFERENCIAS (CLIENTE_ID, CLIENTE_TIPO_DE_REFERENCIA, CLIENTE_REFERENCIA) " +
                        "VALUES (@ID, @TIPODEREFERENCIA, @REFERENCIA) ";

                    comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                    comandoSQL.Parameters.AddWithValue("ID", txtID.Text);
                    comandoSQL.Parameters.AddWithValue("@TIPODEREFERENCIA", cbbTipoDeReferencia.Text);
                    comandoSQL.Parameters.AddWithValue("@REFERENCIA", txtReferencia.Text);

                    stringSQL.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Referência vinculada ao cliente com sucesso!");

                    stringSQL.Close();
                    stringSQL = null;
                    comandoSQL = null;

                    this.Close();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
