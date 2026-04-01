using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace P1
{
    public partial class CadEmpregados : Form
    {
        private SqlConnection conexao;
        private SqlDataAdapter adapter;
        private DataTable tblsetores;
        private SqlCommand comando;
        private string strsql, strconex;

        public CadEmpregados()
        {
            InitializeComponent();
        }

        private void CadEmpregados_Load(object sender, EventArgs e)
        {
            strconex = "data source=(local);initial catalog=empresa;integrated security=sspi";
            conexao = new SqlConnection(strconex);
            
            try
            {
                conexao.Open();
                tblsetores = new DataTable();
                strsql = "select * from setores";
                adapter = new SqlDataAdapter(strsql, conexao);
                adapter.Fill(tblsetores);

                cboCodSetor.DataSource = tblsetores;
                cboCodSetor.DisplayMember = "setor";
                cboCodSetor.ValueMember = "codsetor";
                if(cboCodSetor.SelectedValue != null)
                {
                    lblcodsetor.Text = cboCodSetor.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os setores: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }

        private void CboCodSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCodSetor.SelectedValue != null && !(cboCodSetor.SelectedValue is DataRowView))
            {
                lblcodsetor.Text = cboCodSetor.SelectedValue.ToString();
            }
        }

        private void Btgravar_Click(object sender, EventArgs e)
        {
            try
            {
                strconex = "data source=(local);initial catalog=empresa;integrated security=sspi";
                conexao = new SqlConnection(strconex);
                conexao.Open();

                strsql = "insert into empregados (codempregado, empregado, bairro, cidade, codsetor) " +
                         "values ('" + txtCodEmpregado.Text + "','" + txtEmpregado.Text + "','" + 
                         txtBairro.Text + "','" + txtCidade.Text + "','" + cboCodSetor.SelectedValue + "')";

                comando = new SqlCommand(strsql, conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso.", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro ao gravar: " + er.Message, "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexao.Close();
            }
        }

        private void BtSetores_Click(object sender, EventArgs e)
        {
            Form1 formSetores = new Form1();
            formSetores.Show();
            this.Hide();
        }
    }
}
