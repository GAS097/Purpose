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
using Purpose.Entities.Enums;
using EnumeratorDescription;
using Microsoft.VisualBasic;

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
            DataTable dtClientes = new DataTable();
            DataTable dtReferencias = new DataTable();

            // Adicionando colunas ao data grid view Clientes
            dtClientes.Columns.Add("ID", typeof(int));
            dtClientes.Columns.Add("Nome", typeof(string));
            dtClientes.Columns.Add("Telefone", typeof(int));
            dtClientes.Columns.Add("Data de Nascimento", typeof(string));

            dgvClientes.DataSource = dtClientes;

            // Adicionando colunas ao data grid view Referencias
            dtReferencias.Columns.Add("ID Cliente", typeof(int));
            dtReferencias.Columns.Add("ID Referencia", typeof(int));
            dtReferencias.Columns.Add("Referencia", typeof(string));
            dtReferencias.Columns.Add("Tipo de Referencia", typeof(int));

            dgvReferenciaClientes.DataSource = dtReferencias;

            // Validação de tamanho máximo do campo Telefone
            txtTelefone.MaxLength = 11;

            // Validação de data máxima do campo Data de Nascimento (hoje)
            dtpDataDeNascimento.MaxDate = DateTime.Today;

            //fhn

        }

        public static DataGridViewRow ClienteSelecionado { get; set; }
        public static DataGridViewRow ReferenciaSelecionada { get; set; }


        // Validação do campo telefone para aceitar apenas números
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ApenasNumeros(e);
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            // O que irá acontecer ao clicar no botão Incluir com a aba de Clientes aberta
            if (tpClientes.Focus())
            {
                IncluirCliente incluirCliente = new IncluirCliente();
                incluirCliente.Show();
            }
            // O que irá acontecer ao clicar no botão Incluir com a aba de Referências aberta
            else if (tpReferencias.Focus())
            {
                DataGridViewRow linhaSelecionada = dgvClientes.CurrentRow;
                IncluirReferenciaDeCliente incluirReferencia = new IncluirReferenciaDeCliente();

                if (linhaSelecionada == null)
                {
                    MessageBox.Show("Filtre e selecione um cliente para alterar.");
                }
                else
                {
                    ClienteSelecionado = linhaSelecionada;

                    incluirReferencia.txtID.Text = CadastroDeClientes.ClienteSelecionado.Cells[0].Value.ToString();
                    incluirReferencia.txtNome.Text = CadastroDeClientes.ClienteSelecionado.Cells[1].Value.ToString();

                    incluirReferencia.Show();
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                stringSQL = new SqlConnection(connectionString);
                scriptSQL = "SELECT * FROM TB_CLIENTES WHERE CLIENTE_NOME = @NOME OR CLIENTE_TELEFONE = @TELEFONE OR CLIENTE_DATA_DE_NASCIMENTO = @DATADENASCIMENTO";

                comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                comandoSQL.Parameters.AddWithValue("@NOME", txtNome.Text);
                comandoSQL.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comandoSQL.Parameters.AddWithValue("@DATADENASCIMENTO", Convert.ToDateTime(dtpDataDeNascimento.Text));

                stringSQL.Open();
                dr = comandoSQL.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["CLIENTE_NOME"];
                    txtTelefone.Text = Convert.ToString(dr["CLIENTE_TELEFONE"]);
                    dtpDataDeNascimento.Text = Convert.ToString(dr["CLIENTE_DATA_DE_NASCIMENTO"]);
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
                da = new SqlDataAdapter(scriptSQL, stringSQL);

                stringSQL.Open();

                da.Fill(dataSet);

                dgvClientes.DataSource = dataSet.Tables[0];

                comandoSQL = new SqlCommand(scriptSQL, stringSQL);
                dr = comandoSQL.ExecuteReader();
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
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataGridViewRow clienteSelecionado = dgvClientes.CurrentRow;
            DataGridViewRow referenciaSelecionada = dgvReferenciaClientes.CurrentRow;
            AlterarCliente alterarCliente = new AlterarCliente();
            AlterarReferenciaDoCliente alterarReferencia = new AlterarReferenciaDoCliente();

            // O que irá acontecer ao clicar no botão ALTERAR com a aba de Clientes aberta
            if (tpClientes.Focus())
            {
                if (clienteSelecionado == null)
                {
                    MessageBox.Show("Filtre e selecione um cliente para alterar.");
                }
                else
                {
                    ClienteSelecionado = clienteSelecionado;

                    alterarCliente.txtID.Text = CadastroDeClientes.ClienteSelecionado.Cells[0].Value.ToString();
                    alterarCliente.txtNome.Text = CadastroDeClientes.ClienteSelecionado.Cells[1].Value.ToString();
                    alterarCliente.txtTelefone.Text = CadastroDeClientes.ClienteSelecionado.Cells[2].Value.ToString();
                    alterarCliente.dtpDataDeNascimento.Text = CadastroDeClientes.ClienteSelecionado.Cells[3].Value.ToString();

                    alterarCliente.Show();
                }
            }
            // O que irá acontecer ao clicar no botão ALTERAR com a aba de Referências aberta
            else if (tpReferencias.Focus())
            {

                if (clienteSelecionado == null)
                {
                    MessageBox.Show("Filtre e selecione um cliente para ver e alterar as referencias.");
                }
                else
                {
                    ClienteSelecionado = clienteSelecionado;
                    ReferenciaSelecionada = referenciaSelecionada;

                    /*alterarReferencia.txtIDReferencia.Text = ReferenciaSelecionada.Cells[0].Value.ToString();
                    alterarReferencia.txtReferencia.Text = CadastroDeClientes.ReferenciaSelecionada.Cells[1].Value.ToString();
                    alterarReferencia.cbbTipoDeReferencia.Text = CadastroDeClientes.ReferenciaSelecionada.Cells[3].Value.ToString();*/
                    alterarReferencia.txtIDCliente.Text = CadastroDeClientes.ClienteSelecionado.Cells[0].Value.ToString();
                    alterarReferencia.txtNomeCliente.Text = CadastroDeClientes.ClienteSelecionado.Cells[1].Value.ToString();

                    alterarReferencia.Show();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = dgvClientes.CurrentRow;
            DataGridViewRow referenciaSelecionada = dgvReferenciaClientes.CurrentRow;

            if (tpClientes.Focus())
            {
                if (linhaSelecionada == null)
                {
                    MessageBox.Show("Filtre e selecione um cliente para excluir.");
                }
                else
                {
                    try
                    {
                        ClienteSelecionado = linhaSelecionada;

                        var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                        stringSQL = new SqlConnection(connectionString);
                        scriptSQL = "DELETE TB_CLIENTES WHERE CLIENTE_ID = @ID";

                        comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                        comandoSQL.Parameters.AddWithValue("@ID", CadastroDeClientes.ClienteSelecionado.Cells[0].Value.ToString()); ;

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

                        stringSQL.Close();
                        stringSQL = null;
                        comandoSQL = null;
                    }
                }
            }

            if (tpReferencias.Focus())
            {
                if (linhaSelecionada == null)
                {
                    MessageBox.Show("Filtre e selecione um cliente para excluir sua referência.");
                }
                else
                {
                    try
                    {
                        ClienteSelecionado = linhaSelecionada;
                        ReferenciaSelecionada = referenciaSelecionada;

                        var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                        stringSQL = new SqlConnection(connectionString);
                        scriptSQL = "DELETE TB_CLIENTES_REFERENCIAS WHERE REFERENCIA_ID = @REFERENCIAID";

                        comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                        comandoSQL.Parameters.AddWithValue("@REFERENCIAID", ReferenciaSelecionada.Cells[0].Value.ToString());

                        stringSQL.Open();
                        comandoSQL.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show("Referêcia excluída com sucesso!");

                        stringSQL.Close();
                        stringSQL = null;
                        comandoSQL = null;
                    }
                }
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tpReferencias_Enter(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linhaSelecionada = dgvClientes.CurrentRow;
                ClienteSelecionado = linhaSelecionada;

                var connectionString = ConfigurationManager.ConnectionStrings["Purpose"].ConnectionString;

                stringSQL = new SqlConnection(connectionString);
                scriptSQL = "DECLARE CLIENTE_ID  INT SELECT * FROM TB_CLIENTES_REFERENCIAS WHERE CLIENTE_ID = @CLIENTE_ID";

                comandoSQL = new SqlCommand(scriptSQL, stringSQL);

                comandoSQL.Parameters.AddWithValue("@CLIENTE_ID", CadastroDeClientes.ClienteSelecionado.Cells[0].Value);

                stringSQL.Open();
                comandoSQL.ExecuteNonQuery();

                DataSet dataSet = new DataSet();
                da = new SqlDataAdapter(scriptSQL, stringSQL);

                da.Fill(dataSet);

                dgvReferenciaClientes.DataSource = dataSet.Tables[0];
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
