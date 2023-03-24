using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_Construir_Desktop
{
    public partial class frmLogin : Form
    {
        private RepositorioUsuario respositorioAluno = new RepositorioUsuario();
        public frmLogin()
        {
            InitializeComponent();
            MapeiaNomeUsuarios();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgOlhosAbertos_Click(object sender, EventArgs e)
        {
            if (!txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar = true;
                imgOlhosAbertos.Visible = false;
                imgOlhosFechados.Visible = true;
            }
        }

        private void imgOlhosFechados_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar = false;
                imgOlhosAbertos.Visible = true;
                imgOlhosFechados.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Nome = comboBoxUsuarios.Text;
            usuarios.Senha = txtSenha.Text;

            if (respositorioAluno.Logar(usuarios.Nome, usuarios.Senha))
            {
                frmPrincipal frmPrincipal = new frmPrincipal(usuarios.Nome);
                this.Hide();
                frmPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MapeiaNomeUsuarios()
        {
            foreach(String nomeUsuarios in respositorioAluno.ListaNomeUsuarios())
            {
                comboBoxUsuarios.Items.Add(nomeUsuarios);
            }
            comboBoxUsuarios.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
