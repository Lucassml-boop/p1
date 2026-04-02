using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace P1
{
    public partial class Form1 : Form
    {
        string conexao = "Data Source=localhost;Initial Catalog=empresa;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btgravar_Click(object sender, EventArgs e)
        {
            if (txtCodSetor.Text == "" || txtSetor.Text == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios!");
                return;
            }

            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                conn.Open();

                string sql = "INSERT INTO setores (codsetor, setor, descricao_setor) VALUES (@cod, @setor, @descricao)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cod", int.Parse(txtCodSetor.Text));
                cmd.Parameters.AddWithValue("@setor", txtSetor.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Setor cadastrado com sucesso!");

                
                txtCodSetor.Clear();
                txtSetor.Clear();
                txtDescricao.Clear();

                txtCodSetor.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar: " + erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        
        private void BtEmpregados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela de empregados ainda não implementada.");
        }
    }
}