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
            this.consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCartõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasdeconexao = new System.Windows.Forms.ToolStripMenuItem();
            this.setarOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setarOfflineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidades = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarDataEHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPortaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catracaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemploDeConversãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeExibiçãoDoAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picCamImagem = new System.Windows.Forms.PictureBox();
            this.picImagemRecortada = new System.Windows.Forms.PictureBox();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemRecortada)).BeginInit();
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
            this.groupBox2.Location = new System.Drawing.Point(23, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1131, 720);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matricula:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(847, 29);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(246, 46);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(252, 51);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(198, 26);
            this.txtId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "iD do Usuário";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(252, 91);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(198, 26);
            this.txtUser.TabIndex = 2;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(252, 131);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(198, 26);
            this.txtMatricula.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastros,
            this.consultas,
            this.formasdeconexao,
            this.utilidades});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1167, 33);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastros
            // 
            this.cadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.terminalToolStripMenuItem});
            this.cadastros.Name = "cadastros";
            this.cadastros.Size = new System.Drawing.Size(107, 29);
            this.cadastros.Text = "Cadastros";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Usuário";
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.terminalToolStripMenuItem.Text = "Terminal";
            this.terminalToolStripMenuItem.Click += new System.EventHandler(this.terminalToolStripMenuItem_Click);
            // 
            // consultas
            // 
            this.consultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosCadastradosToolStripMenuItem,
            this.logsDeAcessoToolStripMenuItem,
            this.listarCartõesToolStripMenuItem});
            this.consultas.Name = "consultas";
            this.consultas.Size = new System.Drawing.Size(105, 29);
            this.consultas.Text = "Consultas";
            // 
            // usuariosCadastradosToolStripMenuItem
            // 
            this.usuariosCadastradosToolStripMenuItem.Name = "usuariosCadastradosToolStripMenuItem";
            this.usuariosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.usuariosCadastradosToolStripMenuItem.Text = "Listar Usuarios";
            // 
            // logsDeAcessoToolStripMenuItem
            // 
            this.logsDeAcessoToolStripMenuItem.Name = "logsDeAcessoToolStripMenuItem";
            this.logsDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.logsDeAcessoToolStripMenuItem.Text = "Listar Logs";
            // 
            // listarCartõesToolStripMenuItem
            // 
            this.listarCartõesToolStripMenuItem.Name = "listarCartõesToolStripMenuItem";
            this.listarCartõesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listarCartõesToolStripMenuItem.Text = "Listar Cartões";
            // 
            // formasdeconexao
            // 
            this.formasdeconexao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setarOnlineToolStripMenuItem,
            this.setarOfflineToolStripMenuItem});
            this.formasdeconexao.Name = "formasdeconexao";
            this.formasdeconexao.Size = new System.Drawing.Size(186, 29);
            this.formasdeconexao.Text = "Formas de Conexao";
            // 
            // setarOnlineToolStripMenuItem
            // 
            this.setarOnlineToolStripMenuItem.Name = "setarOnlineToolStripMenuItem";
            this.setarOnlineToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.setarOnlineToolStripMenuItem.Text = "Setar Online";
            // 
            // setarOfflineToolStripMenuItem
            // 
            this.setarOfflineToolStripMenuItem.Name = "setarOfflineToolStripMenuItem";
            this.setarOfflineToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.setarOfflineToolStripMenuItem.Text = "Setar Offline";
            // 
            // utilidades
            // 
            this.utilidades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarDataEHoraToolStripMenuItem,
            this.abrirPortaToolStripMenuItem,
            this.exemploDeConversãoToolStripMenuItem,
            this.nomeExibiçãoDoAcessoToolStripMenuItem});
            this.utilidades.Name = "utilidades";
            this.utilidades.Size = new System.Drawing.Size(106, 29);
            this.utilidades.Text = "Utilidades";
            // 
            // atualizarDataEHoraToolStripMenuItem
            // 
            this.atualizarDataEHoraToolStripMenuItem.Name = "atualizarDataEHoraToolStripMenuItem";
            this.atualizarDataEHoraToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.atualizarDataEHoraToolStripMenuItem.Text = "Atualizar Data e Hora";
            // 
            // abrirPortaToolStripMenuItem
            // 
            this.abrirPortaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catracaToolStripMenuItem,
            this.acessoToolStripMenuItem});
            this.abrirPortaToolStripMenuItem.Name = "abrirPortaToolStripMenuItem";
            this.abrirPortaToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.abrirPortaToolStripMenuItem.Text = "Liberar Acesso";
            // 
            // catracaToolStripMenuItem
            // 
            this.catracaToolStripMenuItem.Name = "catracaToolStripMenuItem";
            this.catracaToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.catracaToolStripMenuItem.Text = "Catraca";
            // 
            // acessoToolStripMenuItem
            // 
            this.acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            this.acessoToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.acessoToolStripMenuItem.Text = "Acesso";
            // 
            // exemploDeConversãoToolStripMenuItem
            // 
            this.exemploDeConversãoToolStripMenuItem.Name = "exemploDeConversãoToolStripMenuItem";
            this.exemploDeConversãoToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.exemploDeConversãoToolStripMenuItem.Text = "Conversão Wiegand";
            // 
            // nomeExibiçãoDoAcessoToolStripMenuItem
            // 
            this.nomeExibiçãoDoAcessoToolStripMenuItem.Name = "nomeExibiçãoDoAcessoToolStripMenuItem";
            this.nomeExibiçãoDoAcessoToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.nomeExibiçãoDoAcessoToolStripMenuItem.Text = "Nome exibição do Acesso";
            // 
            // picCamImagem
            // 
            this.picCamImagem.Location = new System.Drawing.Point(33, 192);
            this.picCamImagem.Name = "picCamImagem";
            this.picCamImagem.Size = new System.Drawing.Size(447, 289);
            this.picCamImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamImagem.TabIndex = 7;
            this.picCamImagem.TabStop = false;
            // 
            // picImagemRecortada
            // 
            this.picImagemRecortada.Location = new System.Drawing.Point(646, 192);
            this.picImagemRecortada.Name = "picImagemRecortada";
            this.picImagemRecortada.Size = new System.Drawing.Size(447, 289);
            this.picImagemRecortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemRecortada.TabIndex = 8;
            this.picImagemRecortada.TabStop = false;
            // 
            // cmbCameras
            // 
            this.cmbCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(94, 504);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(264, 28);
            this.cmbCameras.TabIndex = 9;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(94, 553);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(264, 46);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "Iniciar Captura";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(94, 609);
            this.btnEncerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(264, 46);
            this.btnEncerrar.TabIndex = 11;
            this.btnEncerrar.Text = "Encerrar Captura";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(771, 514);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(264, 46);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar Captura";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 795);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Incial";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCamImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemRecortada)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem consultas;
        private System.Windows.Forms.ToolStripMenuItem usuariosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsDeAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCartõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasdeconexao;
        private System.Windows.Forms.ToolStripMenuItem setarOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setarOfflineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilidades;
        private System.Windows.Forms.ToolStripMenuItem atualizarDataEHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPortaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catracaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemploDeConversãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeExibiçãoDoAcessoToolStripMenuItem;
        private System.Windows.Forms.PictureBox picImagemRecortada;
        private System.Windows.Forms.PictureBox picCamImagem;
        private System.Windows.Forms.ComboBox cmbCameras;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSalvar;
    }
}

