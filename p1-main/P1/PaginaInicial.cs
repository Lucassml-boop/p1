using System;
using System.Windows.Forms;

namespace P1
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void btSetores_Click(object sender, EventArgs e)
        {
            Form1 frmSetores = new Form1();
            frmSetores.Show();
        }

        private void btEmpregados_Click(object sender, EventArgs e)
        {
            CadEmpregados frmEmpregados = new CadEmpregados();
            frmEmpregados.Show();
        }
    }
}
