using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Telas
{
    public partial class frmAlterarProdutos : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmAlterarProdutos()
        {
            InitializeComponent();
        }

        public static void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }


        Business.ProdutoBusiness business = new Business.ProdutoBusiness();
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_produto modelo = new Model.tb_produto();

                byte[] imagem_byte = null;

                FileStream fstream = new FileStream(this.txtImagem.Text, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fstream);

                imagem_byte = br.ReadBytes((int)fstream.Length);

                modelo.img_produto = imagem_byte;
                modelo.id_fornecedor = Convert.ToInt32(txtIDFornecedor.Text);
                modelo.ds_categoria = cboCategoria.Text;
                modelo.nm_produto = txtNome.Text;
                modelo.vl_valor = nudValor.Value;

                business.AlterarProduto(modelo);

                MessageBox.Show("Cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdProduto.Text);

            Model.tb_produto modelo = business.Listar(id);

            Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

            Image imagem = imageConverter.byteArrayToImage(modelo.img_produto);

            txtIDFornecedor.Text = modelo.tb_fornecedor.nm_fornecedor;
            txtNome.Text = modelo.nm_produto;
            imgImagem.Image = imagem;
            cboCategoria.Text = modelo.ds_categoria;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|JPEG Files(*.jfif)|*.jfif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtImagem.Text = foto;
                imgImagem.ImageLocation = foto;
            }
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlterarProdutos_Load(object sender, EventArgs e)
        {
        }
    }
}
