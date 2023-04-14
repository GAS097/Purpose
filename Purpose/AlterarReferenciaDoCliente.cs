using Microsoft.VisualBasic;
using Purpose.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EnumeratorDescription;

namespace Purpose
{
    public partial class AlterarReferenciaDoCliente : Form
    {
        //*Declaração das variáveis de conexão, comando e script para executar no SQL

        SqlConnection stringSQL;
        SqlCommand comandoSQL;

        string scriptSQL;

        //*--------------------------------------------------------------------------

        public AlterarReferenciaDoCliente()
        {
            InitializeComponent();

            cbbTipoDeReferencia.DataSource = Enum.GetValues(typeof(TipoDeReferencia));
        }

        private void cbbTipoDeReferencia_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value  = (e.Value as Enum).GetDescription();
        }

        private void AlterarReferenciaDoCliente_Load(object sender, EventArgs e)
        {

        }
        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
            txtReferencia.BackColor = Color.White;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtReferencia == null || txtReferencia.MaxLength < 15)
            {
                MessageBox.Show("Descreva a referência deste cliente com pelo menos 15 caracteres.");
                txtReferencia.BackColor = Color.Red;
            }

            else
            {
                try
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                    stringSQL = new SqlConnection(connectionString);
                    scriptSQL = "UPDATE TB_CLIENTES_REFERENCIAS SET CLIENTE_TIPO_DE_REFERENCIA = @TIPODEREFERENCIA, CLIENTE_REFERENCIA = @REFERENCIA WHERE REFERENCIA_ID = @REFID";

                    comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                    comandoSQL.Parameters.AddWithValue("@REFID", txtIDReferencia.Text);
                    comandoSQL.Parameters.AddWithValue("@TIPODEREFERENCIA", (int)(TipoDeReferencia)cbbTipoDeReferencia.SelectedItem);
                    comandoSQL.Parameters.AddWithValue("@REFERENCIA", txtReferencia.Text);

                    stringSQL.Open();
                    comandoSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Referência alterada com sucesso!");

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
