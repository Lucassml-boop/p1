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

namespace P1
{
    public partial class Form1 : Form
    {
        private SqlConnection conexao;
        private SqlCommand comando;
        private string strsql, strconex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Btgravar_Click(object sender, EventArgs e)
        {
            try
            {
                strconex = "data source=(local);initial catalog=empresa;integrated security=sspi";

                conexao = new SqlConnection(strconex);
                conexao.Open();

                strsql = "insert into setores (codsetor, setor, descricao) values ('" + 
                         txtCodSetor.Text + "','" + txtSetor.Text + "','" + txtDescricao.Text + "')";

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
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private void BtEmpregados_Click(object sender, EventArgs e)
        {
            CadEmpregados formEmpregados = new CadEmpregados();
            formEmpregados.Show();
            this.Hide();
        }
    }
}
