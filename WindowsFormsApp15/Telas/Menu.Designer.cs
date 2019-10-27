namespace WindowsFormsApp15.Telas
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnConsultarUsuario = new System.Windows.Forms.Button();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnConsultarFornecedor = new System.Windows.Forms.Button();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.btnConsultarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnDespesasEGastos = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnConsultarFolhaPagamento = new System.Windows.Forms.Button();
            this.btnGerarFolhaPagamento = new System.Windows.Forms.Button();
            this.btnConsultarEstoque = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.Controls.Add(this.lblSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 38);
            this.panel1.TabIndex = 325;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(403, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 160;
            this.label3.Text = "Menu";
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMinimizar.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(824, 6);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(21, 23);
            this.lblMinimizar.TabIndex = 156;
            this.lblMinimizar.Text = "_";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.BackColor = System.Drawing.Color.Transparent;
            this.lblSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSair.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(849, 9);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(23, 23);
            this.lblSair.TabIndex = 155;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.imgPerfil);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 566);
            this.panel2.TabIndex = 326;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(21, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(86, 29);
            this.lblNome.TabIndex = 158;
            this.lblNome.Text = "NOME";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // imgPerfil
            // 
            this.imgPerfil.BackColor = System.Drawing.Color.Transparent;
            this.imgPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPerfil.Location = new System.Drawing.Point(24, 65);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(225, 211);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPerfil.TabIndex = 157;
            this.imgPerfil.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(833, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 23);
            this.label1.TabIndex = 156;
            this.label1.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(858, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 155;
            this.label2.Text = "X";
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCadastrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarUsuario.Enabled = false;
            this.btnCadastrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(349, 103);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(236, 43);
            this.btnCadastrarUsuario.TabIndex = 327;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuario";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnConsultarUsuario
            // 
            this.btnConsultarUsuario.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarUsuario.Enabled = false;
            this.btnConsultarUsuario.FlatAppearance.BorderSize = 0;
            this.btnConsultarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarUsuario.Location = new System.Drawing.Point(591, 103);
            this.btnConsultarUsuario.Name = "btnConsultarUsuario";
            this.btnConsultarUsuario.Size = new System.Drawing.Size(235, 43);
            this.btnConsultarUsuario.TabIndex = 328;
            this.btnConsultarUsuario.Text = "Consultar Usuario";
            this.btnConsultarUsuario.UseVisualStyleBackColor = false;
            this.btnConsultarUsuario.Click += new System.EventHandler(this.btnConsultarUsuario_Click);
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnConsultarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(591, 168);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(235, 43);
            this.btnConsultarFuncionario.TabIndex = 330;
            this.btnConsultarFuncionario.Text = "Consultar Funcionario";
            this.btnConsultarFuncionario.UseVisualStyleBackColor = false;
            this.btnConsultarFuncionario.Click += new System.EventHandler(this.btnConsultarFuncionario_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(349, 168);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(236, 43);
            this.btnCadastrarFuncionario.TabIndex = 329;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // btnConsultarFornecedor
            // 
            this.btnConsultarFornecedor.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFornecedor.Enabled = false;
            this.btnConsultarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnConsultarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFornecedor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarFornecedor.Location = new System.Drawing.Point(592, 231);
            this.btnConsultarFornecedor.Name = "btnConsultarFornecedor";
            this.btnConsultarFornecedor.Size = new System.Drawing.Size(235, 43);
            this.btnConsultarFornecedor.TabIndex = 332;
            this.btnConsultarFornecedor.Text = "Consultar Fornecedor";
            this.btnConsultarFornecedor.UseVisualStyleBackColor = false;
            this.btnConsultarFornecedor.Click += new System.EventHandler(this.btnConsultarFornecedor_Click);
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCadastrarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFornecedor.Enabled = false;
            this.btnCadastrarFornecedor.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFornecedor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(350, 231);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(236, 43);
            this.btnCadastrarFornecedor.TabIndex = 331;
            this.btnCadastrarFornecedor.Text = "Cadastrar Fornecedor";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.btnCadastrarFornecedor_Click);
            // 
            // btnConsultarProduto
            // 
            this.btnConsultarProduto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarProduto.Enabled = false;
            this.btnConsultarProduto.FlatAppearance.BorderSize = 0;
            this.btnConsultarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProduto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarProduto.Location = new System.Drawing.Point(593, 291);
            this.btnConsultarProduto.Name = "btnConsultarProduto";
            this.btnConsultarProduto.Size = new System.Drawing.Size(235, 43);
            this.btnConsultarProduto.TabIndex = 334;
            this.btnConsultarProduto.Text = "Consultar Produto";
            this.btnConsultarProduto.UseVisualStyleBackColor = false;
            this.btnConsultarProduto.Click += new System.EventHandler(this.btnConsultarProduto_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCadastrarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarProduto.Enabled = false;
            this.btnCadastrarProduto.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(351, 291);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(236, 43);
            this.btnCadastrarProduto.TabIndex = 333;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnDespesasEGastos
            // 
            this.btnDespesasEGastos.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDespesasEGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespesasEGastos.Enabled = false;
            this.btnDespesasEGastos.FlatAppearance.BorderSize = 0;
            this.btnDespesasEGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesasEGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespesasEGastos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDespesasEGastos.Location = new System.Drawing.Point(592, 487);
            this.btnDespesasEGastos.Name = "btnDespesasEGastos";
            this.btnDespesasEGastos.Size = new System.Drawing.Size(237, 43);
            this.btnDespesasEGastos.TabIndex = 335;
            this.btnDespesasEGastos.Text = "Despesas e Gastos";
            this.btnDespesasEGastos.UseVisualStyleBackColor = false;
            this.btnDespesasEGastos.Click += new System.EventHandler(this.btnDespesasEGastos_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.Enabled = false;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEstoque.Location = new System.Drawing.Point(350, 353);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(236, 43);
            this.btnEstoque.TabIndex = 337;
            this.btnEstoque.Text = "Cadastrar Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaixa.Enabled = false;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCaixa.Location = new System.Drawing.Point(348, 487);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(238, 43);
            this.btnCaixa.TabIndex = 338;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnConsultarFolhaPagamento
            // 
            this.btnConsultarFolhaPagamento.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarFolhaPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFolhaPagamento.Enabled = false;
            this.btnConsultarFolhaPagamento.FlatAppearance.BorderSize = 0;
            this.btnConsultarFolhaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFolhaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFolhaPagamento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarFolhaPagamento.Location = new System.Drawing.Point(593, 413);
            this.btnConsultarFolhaPagamento.Name = "btnConsultarFolhaPagamento";
            this.btnConsultarFolhaPagamento.Size = new System.Drawing.Size(236, 60);
            this.btnConsultarFolhaPagamento.TabIndex = 340;
            this.btnConsultarFolhaPagamento.Text = "Consultar Folha de Pagamento";
            this.btnConsultarFolhaPagamento.UseVisualStyleBackColor = false;
            this.btnConsultarFolhaPagamento.Click += new System.EventHandler(this.btnConsultarFolhaPagamento_Click);
            // 
            // btnGerarFolhaPagamento
            // 
            this.btnGerarFolhaPagamento.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGerarFolhaPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarFolhaPagamento.Enabled = false;
            this.btnGerarFolhaPagamento.FlatAppearance.BorderSize = 0;
            this.btnGerarFolhaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarFolhaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarFolhaPagamento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGerarFolhaPagamento.Location = new System.Drawing.Point(350, 413);
            this.btnGerarFolhaPagamento.Name = "btnGerarFolhaPagamento";
            this.btnGerarFolhaPagamento.Size = new System.Drawing.Size(236, 60);
            this.btnGerarFolhaPagamento.TabIndex = 339;
            this.btnGerarFolhaPagamento.Text = "Gerar Folha de Pagamento";
            this.btnGerarFolhaPagamento.UseVisualStyleBackColor = false;
            this.btnGerarFolhaPagamento.Click += new System.EventHandler(this.btnGerarFolhaPagamento_Click);
            // 
            // btnConsultarEstoque
            // 
            this.btnConsultarEstoque.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarEstoque.Enabled = false;
            this.btnConsultarEstoque.FlatAppearance.BorderSize = 0;
            this.btnConsultarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEstoque.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarEstoque.Location = new System.Drawing.Point(593, 353);
            this.btnConsultarEstoque.Name = "btnConsultarEstoque";
            this.btnConsultarEstoque.Size = new System.Drawing.Size(236, 43);
            this.btnConsultarEstoque.TabIndex = 341;
            this.btnConsultarEstoque.Text = "Consultar Estoque";
            this.btnConsultarEstoque.UseVisualStyleBackColor = false;
            this.btnConsultarEstoque.Click += new System.EventHandler(this.btnConsultarEstoque_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(351, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 43);
            this.button1.TabIndex = 342;
            this.button1.Text = "Caixa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConsultarEstoque);
            this.Controls.Add(this.btnConsultarFolhaPagamento);
            this.Controls.Add(this.btnGerarFolhaPagamento);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnDespesasEGastos);
            this.Controls.Add(this.btnConsultarProduto);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.btnConsultarFornecedor);
            this.Controls.Add(this.btnCadastrarFornecedor);
            this.Controls.Add(this.btnConsultarFuncionario);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.btnConsultarUsuario);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button btnConsultarUsuario;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnConsultarFornecedor;
        private System.Windows.Forms.Button btnCadastrarFornecedor;
        private System.Windows.Forms.Button btnConsultarProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnDespesasEGastos;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnConsultarFolhaPagamento;
        private System.Windows.Forms.Button btnGerarFolhaPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultarEstoque;
        private System.Windows.Forms.Button button1;
    }
}