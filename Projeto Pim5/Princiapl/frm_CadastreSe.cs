using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Pim5
{
    public partial class frm_CadastreSe : Form
    {
        private GerenciadorUsuarios gerenciadorUsuarios;

        public frm_CadastreSe()
        {
            InitializeComponent();
            gerenciadorUsuarios = new GerenciadorUsuarios();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string confSenha = txtConfSenha.Text;

            if (senha != confSenha)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }

            gerenciadorUsuarios.AdicionarUsuario(nome, email, senha);
            MessageBox.Show("Usuário cadastrado com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtConfSenha.Text = "";
        }
    }
}