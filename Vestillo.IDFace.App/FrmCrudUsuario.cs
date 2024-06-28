using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vestillo.IDFace.Entidade;

namespace Vestillo.IDFace.App
{
    public partial class FrmCrudUsuario : Form
    {
        public FrmCrudUsuario()
        {
            InitializeComponent();
        }


        private void EfetuarConsulta()
        {
            var usuarioIDFace = new UsuarioIDFace();
            var lst = usuarioIDFace.RetornarUsuarios();

            dgrdUsuario.DataSource = lst;

        }
        FilterInfoCollection _filterInfoCollection;
        VideoCaptureDevice _videoCaptureDevice;

        private void FrmCrudUsuario_Load(object sender, EventArgs e)
        {
            EfetuarConsulta();
            IniciarProcesso();
        }


        private void IniciarProcesso()
        {
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in _filterInfoCollection)
                cmbCameras.Items.Add(filterInfo.Name);


            cmbCameras.SelectedIndex = 0;
            _videoCaptureDevice = new VideoCaptureDevice();


        }

        private void SalvarCaptura()
        {
            Clipboard.Clear();
            Clipboard.SetImage(picImagemRecortada.Image);
            picCamImagem.Image = Clipboard.GetImage();
            Clipboard.Clear();
            picCamImagem.Image.Save("imagem.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }

        private void EncerrarCaptura()
        {
            if (!(_videoCaptureDevice == null))
                if (_videoCaptureDevice.IsRunning)
                {
                    _videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
                    _videoCaptureDevice.SignalToStop();
                    _videoCaptureDevice = null;
                }
        }


        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            picImagemRecortada.Image = (Bitmap)e.Frame.Clone();

        }

        private void IniciarCaptura()
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cmbCameras.SelectedIndex].MonikerString);
            _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            _videoCaptureDevice.Start();

        }


        private void SelecionarEntidade()
        {
            if (grdusuario.RowCount > 0) {

                var lst = (List<Usuario>)dgrdUsuario.DataSource;

                if (lst != null && lst.Any())
                {
                    var usuarioIDFace = new UsuarioIDFace();
                    var usuario = lst[grdusuario.GetDataSourceRowIndex(grdusuario.FocusedRowHandle)];
                    txtId.Text = usuario.Id;
                    txtUser.Text = usuario.Name;
                    txtMatricula.Text = usuario.Matricula;
                    var vet = usuarioIDFace.GetImagemUsuario(usuario);
                    picCamImagem.Image = null;
                    chkAlteraImagem.Visible = true;
                    chkAlteraImagem.Checked = false;
                    grpCamera.Visible = false;
                    EncerrarCaptura();
                    if (vet != null)
                    {
                       
                        using (var ms = new MemoryStream(vet))
                        {
                            // Criar uma imagem a partir do MemoryStream
                            Image image = Image.FromStream(ms);
                            // Definir a imagem no PictureBox
                            picCamImagem.Image = image;

                            Clipboard.Clear();
                            Clipboard.SetImage(picCamImagem.Image);
                            picCamImagem.Image = Clipboard.GetImage();
                            Clipboard.Clear();
                            picCamImagem.Image.Save("imagem.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }
                }
            
            }
        }
        private byte[] ImageToByteArray(Image imagem)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Salvar a imagem no MemoryStream no formato desejado (ex: JPEG)
                imagem.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void AlterarUsuario()
        {
            try
            {
                var usuario = new Usuario();
                var usuarioIDFace = new UsuarioIDFace();
                usuario.Id = txtId.Text;
                usuario.Name = txtUser.Text;
                usuario.Matricula = txtMatricula.Text;
                if (picCamImagem.Image != null)
                {
                    usuario.Imagem = ImageToByteArray(picCamImagem.Image);
                }

                usuarioIDFace.AlterarUsuario(usuario, "", "");
                MessageBox.Show("Usuário alterado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void grdusuario_DoubleClick(object sender, EventArgs e)
        {
            SelecionarEntidade();
        }

        private void chkAlteraImagem_CheckedChanged(object sender, EventArgs e)
        {
            grpCamera.Visible = chkAlteraImagem.Checked;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarCaptura();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            EncerrarCaptura();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCaptura();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AlterarUsuario();
        }
    }
}
