using Projeto_Construir_Desktop.Gestao_Financeira.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Construir_Desktop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(String nome)
        {
            InitializeComponent();

            label1.Text = nome;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void bancosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroBancos frmCadastroBancos = new frmCadastroBancos();
            frmCadastroBancos.ShowDialog();
        }
    }
}
