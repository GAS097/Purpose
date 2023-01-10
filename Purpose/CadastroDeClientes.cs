using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Purpose
{

    public partial class CadastroDeClientes : Form
    {
        public static System.Configuration.ConnectionStringSettingsCollection ConnectionStrings { get; }

        SqlConnection stringSQL;
        SqlCommand comandoSQL;
        SqlDataAdapter da;
        SqlDataReader dr;

        string scriptSQL;
        public CadastroDeClientes()
        {
            InitializeComponent();
        }
        private void CadastroDeClientes_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //*Adicionando colunas ao data grid view
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Telefone", typeof(int));
            dt.Columns.Add("Data de Nascimento", typeof(string));

            txtTelefone.MaxLength = 11;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            IncluirCliente incluirCliente = new IncluirCliente();
            incluirCliente.Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                stringSQL = new SqlConnection(connectionString);
                scriptSQL = "SELECT * FROM TB_CLIENTES WHERE NOME = @NOME OR TELEFONE = @TELEFONE OR DATADENASCIMENTO = @DATADENASCIMENTO";

                comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                comandoSQL.Parameters.AddWithValue("@NOME", txtNome.Text);
                comandoSQL.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comandoSQL.Parameters.AddWithValue("@DATADENASCIMENTO", Convert.ToDateTime(dtpDataDeNascimento.Text));

                stringSQL.Open();
                dr = comandoSQL.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["NOME"];
                    txtTelefone.Text = Convert.ToString(dr["TELEFONE"]);
                    dtpDataDeNascimento.Text = Convert.ToString(dr["DATADENASCIMENTO"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                stringSQL.Close();
                stringSQL = null;
                comandoSQL = null;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                stringSQL = new SqlConnection(connectionString);
                scriptSQL = "SELECT * FROM TB_CLIENTES";

                DataSet dataSet = new DataSet();
                da = new SqlDataAdapter(scriptSQL,stringSQL);

                stringSQL.Open();

                da.Fill(dataSet);

                dgvClientes.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                stringSQL.Close();
                stringSQL = null;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                stringSQL = new SqlConnection(connectionString);
                scriptSQL = "UPDATE TB_CLIENTES SET NOME = @NOME, TELEFONE = @TELEFONE, DATADENASCIMENTO = @DATADENASCIMENTO WHERE NOME = @NOME";

                comandoSQL = new SqlCommand(scriptSQL, stringSQL);

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

                txtNome.Text = "";
                txtTelefone.Text = "";
                dtpDataDeNascimento.Text = "";

                stringSQL.Close();
                stringSQL = null;
                comandoSQL = null;
            }
            //AlterarCliente alterarCliente = new AlterarCliente();
            //alterarCliente.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                stringSQL = new SqlConnection(connectionString);
                scriptSQL = "DELETE TB_CLIENTES WHERE NOME = @NOME";

                comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                comandoSQL.Parameters.AddWithValue("@NOME", txtNome.Text);

                stringSQL.Open();
                comandoSQL.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Cliente excluído com sucesso!");

                txtNome.Text = "";
                txtTelefone.Text = "";
                dtpDataDeNascimento.Text = "";

                stringSQL.Close();
                stringSQL = null;
                comandoSQL = null;
            }
        }
    }
}
