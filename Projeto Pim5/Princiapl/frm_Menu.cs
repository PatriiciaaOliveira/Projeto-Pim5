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
    public partial class frm_Menu : Form
    {
        private GerenciadorUsuarios gerenciadorUsuarios;

        public frm_Menu()
        {
            InitializeComponent();
            gerenciadorUsuarios = new GerenciadorUsuarios();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (gerenciadorUsuarios.AutenticarUsuario(login, senha))
            {
                MessageBox.Show("Login bem-sucedido!");
                // Coloque o código para abrir o próximo formulário ou realizar outras ações após o login bem-sucedido.
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!");
            }
        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            gerenciadorUsuarios.AdicionarUsuario(login, senha);
            MessageBox.Show("Usuário cadastrado com sucesso!");
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}