using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Business.UsuarioBusiness business = new Business.UsuarioBusiness();

                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                bool login = business.Usuario(usuario, senha);

                Model.tb_usuario usuarioTB = business.ModeloUsuario(usuario, senha);

                Objetos.Usuario.UsuarioLogado.ID = usuarioTB.id_usuario;
                Objetos.Usuario.UsuarioLogado.Usuario = usuarioTB.nm_usuario;
                Objetos.Usuario.UsuarioLogado.Senha = usuarioTB.nm_usuario;
                Objetos.Usuario.UsuarioLogado.Email = usuarioTB.ds_senha;
                Objetos.Usuario.UsuarioLogado.Cargo = usuarioTB.ds_email;

                if (login == true)
                {
                    MessageBox.Show("login efetuado com sucesso");
                }
                else
                {
                    MessageBox.Show("Credenciais incorretas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Telas.frmCadastrarUsuario tela = new Telas.frmCadastrarUsuario();
            tela.Show();
        }
    }
}
