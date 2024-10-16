﻿namespace Vestillo.IDFace.App
{
    partial class FrmCrudUsuario
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
            this.dgrdUsuario = new DevExpress.XtraGrid.GridControl();
            this.grdusuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.picCamImagem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.chkAlteraImagem = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            this.picImagemRecortada = new System.Windows.Forms.PictureBox();
            this.grpCamera = new DevExpress.XtraEditors.GroupControl();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemRecortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCamera)).BeginInit();
            this.grpCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrdUsuario
            // 
            this.dgrdUsuario.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgrdUsuario.Location = new System.Drawing.Point(16, 18);
            this.dgrdUsuario.MainView = this.grdusuario;
            this.dgrdUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgrdUsuario.Name = "dgrdUsuario";
            this.dgrdUsuario.Size = new System.Drawing.Size(344, 370);
            this.dgrdUsuario.TabIndex = 0;
            this.dgrdUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdusuario});
            // 
            // grdusuario
            // 
            this.grdusuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colMatricula});
            this.grdusuario.DetailHeight = 227;
            this.grdusuario.GridControl = this.dgrdUsuario;
            this.grdusuario.Name = "grdusuario";
            this.grdusuario.OptionsBehavior.Editable = false;
            this.grdusuario.OptionsEditForm.PopupEditFormWidth = 533;
            this.grdusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdusuario_KeyDown);
            this.grdusuario.DoubleClick += new System.EventHandler(this.grdusuario_DoubleClick);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Nome";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colMatricula
            // 
            this.colMatricula.Caption = "Matricula";
            this.colMatricula.FieldName = "Matricula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.Visible = true;
            this.colMatricula.VisibleIndex = 2;
            // 
            // picCamImagem
            // 
            this.picCamImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCamImagem.Location = new System.Drawing.Point(371, 98);
            this.picCamImagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCamImagem.Name = "picCamImagem";
            this.picCamImagem.Size = new System.Drawing.Size(272, 189);
            this.picCamImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamImagem.TabIndex = 14;
            this.picCamImagem.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome do usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Matricula:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(510, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(133, 20);
            this.txtId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "iD do Usuário";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(510, 44);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(133, 20);
            this.txtUser.TabIndex = 9;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(510, 70);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(133, 20);
            this.txtMatricula.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(31, 536);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(164, 30);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Gravar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // chkAlteraImagem
            // 
            this.chkAlteraImagem.AutoSize = true;
            this.chkAlteraImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlteraImagem.Location = new System.Drawing.Point(371, 290);
            this.chkAlteraImagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAlteraImagem.Name = "chkAlteraImagem";
            this.chkAlteraImagem.Size = new System.Drawing.Size(234, 28);
            this.chkAlteraImagem.TabIndex = 16;
            this.chkAlteraImagem.Text = "Deseja Alterar Imagem ?";
            this.chkAlteraImagem.UseVisualStyleBackColor = true;
            this.chkAlteraImagem.Visible = false;
            this.chkAlteraImagem.CheckedChanged += new System.EventHandler(this.chkAlteraImagem_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(322, 89);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(176, 30);
            this.btnEncerrar.TabIndex = 20;
            this.btnEncerrar.Text = "Encerrar Captura";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(322, 53);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(176, 30);
            this.btnIniciar.TabIndex = 19;
            this.btnIniciar.Text = "Iniciar Captura";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // cmbCameras
            // 
            this.cmbCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(322, 30);
            this.cmbCameras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(177, 21);
            this.cmbCameras.TabIndex = 18;
            // 
            // picImagemRecortada
            // 
            this.picImagemRecortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagemRecortada.Location = new System.Drawing.Point(13, 30);
            this.picImagemRecortada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picImagemRecortada.Name = "picImagemRecortada";
            this.picImagemRecortada.Size = new System.Drawing.Size(299, 189);
            this.picImagemRecortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemRecortada.TabIndex = 17;
            this.picImagemRecortada.TabStop = false;
            // 
            // grpCamera
            // 
            this.grpCamera.Controls.Add(this.btnSalvar);
            this.grpCamera.Controls.Add(this.picImagemRecortada);
            this.grpCamera.Controls.Add(this.btnEncerrar);
            this.grpCamera.Controls.Add(this.btnIniciar);
            this.grpCamera.Controls.Add(this.cmbCameras);
            this.grpCamera.Location = new System.Drawing.Point(371, 330);
            this.grpCamera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCamera.Name = "grpCamera";
            this.grpCamera.Size = new System.Drawing.Size(510, 236);
            this.grpCamera.TabIndex = 21;
            this.grpCamera.Text = "Captura";
            this.grpCamera.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(322, 125);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(176, 30);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar Captura";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCrudUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 578);
            this.Controls.Add(this.grpCamera);
            this.Controls.Add(this.chkAlteraImagem);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.picCamImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.dgrdUsuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCrudUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Usuário";
            this.Load += new System.EventHandler(this.FrmCrudUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemRecortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCamera)).EndInit();
            this.grpCamera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgrdUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView grdusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colMatricula;
        private System.Windows.Forms.PictureBox picCamImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox chkAlteraImagem;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox cmbCameras;
        private System.Windows.Forms.PictureBox picImagemRecortada;
        private DevExpress.XtraEditors.GroupControl grpCamera;
        private System.Windows.Forms.Button btnSalvar;
    }
}