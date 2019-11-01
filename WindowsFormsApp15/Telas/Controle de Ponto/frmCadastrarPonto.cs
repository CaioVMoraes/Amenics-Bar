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
    public partial class frmCadastrarPonto : Form
    {
        public frmCadastrarPonto()
        {
            InitializeComponent();
        }

        Business.ControleDePontoBusiness business = new Business.ControleDePontoBusiness();
        Model.tb_controledeponto ponto = new Model.tb_controledeponto();

        private void frmCadastrarPonto_Load(object sender, EventArgs e)
        {
            lblNome.Text = Autenticacao.Usuario.UsuarioLogado.Nome;

            ponto.id_funcionario = Autenticacao.Usuario.UsuarioLogado.ID;

            ponto.dt_chegada = DateTime.Now;
            ponto.dt_saida = null;
            ponto.dt_saidaAlmoco = null;
            ponto.dt_voltaAlmoco = null;
            ponto.dt_entradaHoraExtra = null;
            ponto.dt_saidaHoraExtra = null;

            business.CadastrarPonto(ponto);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void lblDesligar_Click(object sender, EventArgs e)
        {
            ponto.dt_saida = DateTime.Now;

            business.AlterarPonto(ponto);

            lblComecarHoraExtra.Enabled = true;
            lblComecarHoraExtra.Visible = true;

            lblSaidaHoraExtra.Enabled = true;
            lblSaidaHoraExtra.Visible = true;
        }

        private void lblPausar_Click(object sender, EventArgs e)
        {
            ponto.dt_saidaAlmoco = DateTime.Now;

            business.AlterarPonto(ponto);

            lblPausar.Enabled = false;
            lblVoltarPausa.Enabled = true;
        }

        private void lblVoltarPausa_Click(object sender, EventArgs e)
        {
            ponto.dt_voltaAlmoco = DateTime.Now;

            business.AlterarPonto(ponto);

            lblVoltarPausa.Enabled = false;
        }

        private void lblComecarHoraExtra_Click(object sender, EventArgs e)
        {
            ponto.dt_entradaHoraExtra = DateTime.Now;

            business.AlterarPonto(ponto);

            lblComecarHoraExtra.Enabled = false;
            lblSaidaHoraExtra.Enabled = true;
        }

        private void lblSaidaHoraExtra_Click(object sender, EventArgs e)
        {
            ponto.dt_saidaHoraExtra = DateTime.Now;

            business.AlterarPonto(ponto);

            lblSaidaHoraExtra.Enabled = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if(ponto.dt_saida == null)
            {
                MessageBox.Show("Saída não cadastrada");
            }
            else
            {
                if (ponto.dt_entradaHoraExtra != null && ponto.dt_saidaHoraExtra == null)
                {
                    MessageBox.Show("Saída da hora extra não cadastrada");
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
