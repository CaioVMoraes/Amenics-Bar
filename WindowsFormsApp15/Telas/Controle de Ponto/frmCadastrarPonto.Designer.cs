namespace WindowsFormsApp15.Telas
{
    partial class frmCadastrarPonto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarPonto));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPausar = new System.Windows.Forms.Label();
            this.lblDesligar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblComecarHoraExtra = new System.Windows.Forms.Label();
            this.lblSaidaHoraExtra = new System.Windows.Forms.Label();
            this.lblVoltarPausa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(30, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "label1";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(30, 91);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 20);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label1";
            // 
            // lblPausar
            // 
            this.lblPausar.AutoSize = true;
            this.lblPausar.BackColor = System.Drawing.Color.Transparent;
            this.lblPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPausar.ForeColor = System.Drawing.Color.White;
            this.lblPausar.Location = new System.Drawing.Point(263, 56);
            this.lblPausar.Name = "lblPausar";
            this.lblPausar.Size = new System.Drawing.Size(105, 20);
            this.lblPausar.TabIndex = 2;
            this.lblPausar.Text = "Ir Para Pausa";
            this.lblPausar.Click += new System.EventHandler(this.lblPausar_Click);
            // 
            // lblDesligar
            // 
            this.lblDesligar.AutoSize = true;
            this.lblDesligar.BackColor = System.Drawing.Color.Transparent;
            this.lblDesligar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesligar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDesligar.Location = new System.Drawing.Point(29, 127);
            this.lblDesligar.Name = "lblDesligar";
            this.lblDesligar.Size = new System.Drawing.Size(86, 24);
            this.lblDesligar.TabIndex = 3;
            this.lblDesligar.Text = "Desligar";
            this.lblDesligar.Click += new System.EventHandler(this.lblDesligar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblComecarHoraExtra
            // 
            this.lblComecarHoraExtra.AutoSize = true;
            this.lblComecarHoraExtra.BackColor = System.Drawing.Color.Transparent;
            this.lblComecarHoraExtra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblComecarHoraExtra.Enabled = false;
            this.lblComecarHoraExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComecarHoraExtra.ForeColor = System.Drawing.Color.White;
            this.lblComecarHoraExtra.Location = new System.Drawing.Point(547, 56);
            this.lblComecarHoraExtra.Name = "lblComecarHoraExtra";
            this.lblComecarHoraExtra.Size = new System.Drawing.Size(151, 20);
            this.lblComecarHoraExtra.TabIndex = 4;
            this.lblComecarHoraExtra.Text = "Começar Hora extra";
            this.lblComecarHoraExtra.Visible = false;
            this.lblComecarHoraExtra.Click += new System.EventHandler(this.lblComecarHoraExtra_Click);
            // 
            // lblSaidaHoraExtra
            // 
            this.lblSaidaHoraExtra.AutoSize = true;
            this.lblSaidaHoraExtra.BackColor = System.Drawing.Color.Transparent;
            this.lblSaidaHoraExtra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSaidaHoraExtra.Enabled = false;
            this.lblSaidaHoraExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidaHoraExtra.ForeColor = System.Drawing.Color.White;
            this.lblSaidaHoraExtra.Location = new System.Drawing.Point(547, 91);
            this.lblSaidaHoraExtra.Name = "lblSaidaHoraExtra";
            this.lblSaidaHoraExtra.Size = new System.Drawing.Size(128, 20);
            this.lblSaidaHoraExtra.TabIndex = 5;
            this.lblSaidaHoraExtra.Text = "Saída Hora extra";
            this.lblSaidaHoraExtra.Visible = false;
            this.lblSaidaHoraExtra.Click += new System.EventHandler(this.lblSaidaHoraExtra_Click);
            // 
            // lblVoltarPausa
            // 
            this.lblVoltarPausa.AutoSize = true;
            this.lblVoltarPausa.BackColor = System.Drawing.Color.Transparent;
            this.lblVoltarPausa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltarPausa.Enabled = false;
            this.lblVoltarPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltarPausa.ForeColor = System.Drawing.Color.White;
            this.lblVoltarPausa.Location = new System.Drawing.Point(263, 91);
            this.lblVoltarPausa.Name = "lblVoltarPausa";
            this.lblVoltarPausa.Size = new System.Drawing.Size(122, 20);
            this.lblVoltarPausa.TabIndex = 6;
            this.lblVoltarPausa.Text = "Voltar da Pausa";
            this.lblVoltarPausa.Click += new System.EventHandler(this.lblVoltarPausa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(703, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(679, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "_";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 28);
            this.panel1.TabIndex = 308;
            // 
            // frmCadastrarPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApp15.Properties.Resources._3907f0a4052ed31662981053bbf12c4e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 180);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVoltarPausa);
            this.Controls.Add(this.lblSaidaHoraExtra);
            this.Controls.Add(this.lblComecarHoraExtra);
            this.Controls.Add(this.lblDesligar);
            this.Controls.Add(this.lblPausar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarPonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastrar Controle de Ponto";
            this.Load += new System.EventHandler(this.frmCadastrarPonto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPausar;
        private System.Windows.Forms.Label lblDesligar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblComecarHoraExtra;
        private System.Windows.Forms.Label lblSaidaHoraExtra;
        private System.Windows.Forms.Label lblVoltarPausa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}