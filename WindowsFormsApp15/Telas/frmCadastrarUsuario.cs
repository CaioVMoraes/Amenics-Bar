using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15.Telas
{
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Business.UsuarioBusiness business = new Business.UsuarioBusiness();

                Model.tb_usuario model = new Model.tb_usuario();

                model.nm_usuario = txtUsuario.Text.Trim();
                model.ds_email = txtEmail.Text.Trim();
                model.ds_senha = txtSenha.Text.Trim();
                model.ds_cargo = cboCargo.Text.Trim();
                string confirmar = txtConfirmarSenha.Text.Trim();

                business.inserirUsuario(model, confirmar);

                MessageBox.Show("Cadastrado com sucesso", "Cadastro de Usuário", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
