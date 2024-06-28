namespace Vestillo.IDFace.App
{
    partial class FrmPrincipal
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.picImagemRecortada = new System.Windows.Forms.PictureBox();
            this.picCamImagem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasdeconexao = new System.Windows.Forms.ToolStripMenuItem();
            this.setarOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setarOfflineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liberarAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemRecortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamImagem)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnEncerrar);
            this.groupBox2.Controls.Add(this.btnIniciar);
            this.groupBox2.Controls.Add(this.cmbCameras);
            this.groupBox2.Controls.Add(this.picImagemRecortada);
            this.groupBox2.Controls.Add(this.picCamImagem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCadastrar);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.txtMatricula);
            this.groupBox2.Location = new System.Drawing.Point(15, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 468);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar Usuário";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(514, 334);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(176, 30);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar Captura";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(63, 396);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(176, 30);
            this.btnEncerrar.TabIndex = 11;
            this.btnEncerrar.Text = "Encerrar Captura";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(63, 359);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(176, 30);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "Iniciar Captura";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // cmbCameras
            // 
            this.cmbCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(63, 328);
            this.cmbCameras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(177, 21);
            this.cmbCameras.TabIndex = 9;
            // 
            // picImagemRecortada
            // 
            this.picImagemRecortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagemRecortada.Location = new System.Drawing.Point(431, 125);
            this.picImagemRecortada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picImagemRecortada.Name = "picImagemRecortada";
            this.picImagemRecortada.Size = new System.Drawing.Size(299, 189);
            this.picImagemRecortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemRecortada.TabIndex = 8;
            this.picImagemRecortada.TabStop = false;
            // 
            // picCamImagem
            // 
            this.picCamImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCamImagem.Location = new System.Drawing.Point(22, 125);
            this.picCamImagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCamImagem.Name = "picCamImagem";
            this.picCamImagem.Size = new System.Drawing.Size(299, 189);
            this.picCamImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamImagem.TabIndex = 7;
            this.picCamImagem.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matricula:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(585, 432);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(164, 30);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar Usuário";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(168, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(133, 20);
            this.txtId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "iD do Usuário";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(168, 59);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(133, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(168, 85);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(133, 20);
            this.txtMatricula.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastros,
            this.formasdeconexao,
            this.liberarAcessoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastros
            // 
            this.cadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.terminalToolStripMenuItem});
            this.cadastros.Name = "cadastros";
            this.cadastros.Size = new System.Drawing.Size(71, 22);
            this.cadastros.Text = "Cadastros";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.terminalToolStripMenuItem.Text = "Terminal";
            this.terminalToolStripMenuItem.Click += new System.EventHandler(this.terminalToolStripMenuItem_Click);
            // 
            // formasdeconexao
            // 
            this.formasdeconexao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setarOnlineToolStripMenuItem,
            this.setarOfflineToolStripMenuItem});
            this.formasdeconexao.Name = "formasdeconexao";
            this.formasdeconexao.Size = new System.Drawing.Size(124, 22);
            this.formasdeconexao.Text = "Formas de Conexao";
            // 
            // setarOnlineToolStripMenuItem
            // 
            this.setarOnlineToolStripMenuItem.Name = "setarOnlineToolStripMenuItem";
            this.setarOnlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setarOnlineToolStripMenuItem.Text = "Setar Online";
            this.setarOnlineToolStripMenuItem.Click += new System.EventHandler(this.setarOnlineToolStripMenuItem_Click);
            // 
            // setarOfflineToolStripMenuItem
            // 
            this.setarOfflineToolStripMenuItem.Name = "setarOfflineToolStripMenuItem";
            this.setarOfflineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setarOfflineToolStripMenuItem.Text = "Setar Offline";
            this.setarOfflineToolStripMenuItem.Click += new System.EventHandler(this.setarOfflineToolStripMenuItem_Click);
            // 
            // liberarAcessoToolStripMenuItem
            // 
            this.liberarAcessoToolStripMenuItem.Name = "liberarAcessoToolStripMenuItem";
            this.liberarAcessoToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.liberarAcessoToolStripMenuItem.Text = "Liberar acesso";
            this.liberarAcessoToolStripMenuItem.Click += new System.EventHandler(this.liberarAcessoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 517);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Incial";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemRecortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamImagem)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastros;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasdeconexao;
        private System.Windows.Forms.ToolStripMenuItem setarOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setarOfflineToolStripMenuItem;
        private System.Windows.Forms.PictureBox picImagemRecortada;
        private System.Windows.Forms.PictureBox picCamImagem;
        private System.Windows.Forms.ComboBox cmbCameras;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolStripMenuItem liberarAcessoToolStripMenuItem;
    }
}

