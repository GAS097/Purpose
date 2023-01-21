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
            //* Shown += OnShown;
        }        
        private void CadastroDeClientes_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //* Adicionando colunas ao data grid view
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Telefone", typeof(int));
            dt.Columns.Add("Data de Nascimento", typeof(string));

            dgvClientes.DataSource = dt;

            //* Validação de tamanho máximo do campo Telefone
            txtTelefone.MaxLength = 11;

            //* Validação de data máxima do campo Data de Nascimento (hoje)
            dtpDataDeNascimento.MaxDate = DateTime.Today;
        }

        //* Validação do campo telefone para aceitar apenas números
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ApenasNumeros(e);
        }

        /* Carregar informações de referencias do cliente selecionado na DataGridView da aba Referencias
        
        private void OnShown(object sender, EventArgs e)
        {
            tcClientes.SelectedIndexChanged += tpReferenciaOnSelectedIndexChanged;
            Selected();
        }
        private void tpReferenciaOnSelectedIndexChanged(object sender, EventArgs e)
        {
            Selected();
        }
        private void Selected()
        {
            DataGridView dgvReferencias = tcClientes.SelectedIndex switch
            {
                0 => tcClientes.TabPages[0].Controls.OfType<DataGridView>().FirstOrDefault(),
                1 => tcClientes.TabPages[1].Controls.OfType<DataGridView>().FirstOrDefault(),
                2 => tcClientes.TabPages[2].Controls.OfType<DataGridView>().FirstOrDefault(),
                _ => null
            };

            if (dgvReferencias is null)
            {
                MessageBox.Show("Failed to find");
            }
            else
            {
                if (dgvReferencias.CurrentRow != null)
                {
                    var value = dgvReferencias.Rows[dgvReferencias.CurrentRow.Index].Cells[dgvReferencias.CurrentCell.ColumnIndex].Value.ToString();
                }
            }
        }

        */
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            IncluirCliente incluirCliente = new IncluirCliente();
            incluirCliente.Show();

            //*Funções para limpar os campos Nome, Telefone e Data de Nascimento ao finalizar a inclusão do cliente
            txtNome.Text = "";
            txtTelefone.Text = "";
            dtpDataDeNascimento.Text = "";
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

                //*Funções para limpar os campos Nome, Telefone e Data de Nascimento ao finalizar a alteração de um cliente
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

                //*Funções para limpar os campos Nome, Telefone e Data de Nascimento ao finalizar a exclusão de um cliente
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
