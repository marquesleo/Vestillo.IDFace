using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Vestillo.IDFace.Entidade;

namespace Vestillo.IDFace.App
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        FilterInfoCollection _filterInfoCollection;
        VideoCaptureDevice _videoCaptureDevice;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
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
        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmTerminal();
            frm.Show();
        }


        private void IniciarCaptura()
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cmbCameras.SelectedIndex].MonikerString);
            _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            _videoCaptureDevice.Start();
            
        }


        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            picCamImagem.Image = (Bitmap)e.Frame.Clone();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarCaptura();
        }

        private void SalvarCaptura()
        {
            Clipboard.Clear();
            Clipboard.SetImage(picCamImagem.Image);
            picImagemRecortada.Image = Clipboard.GetImage();
            Clipboard.Clear();
            picImagemRecortada.Image.Save("imagem.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCaptura();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            EncerrarCaptura();
        }

        private void IncluirUsuario()
        {
            try
            {
                var usuario = new Usuario();
                var usuarioIDFace = new UsuarioIDFace();
                usuario.Id = Convert.ToInt32(txtId.Text);
                usuario.Name = txtUser.Text;
                usuario.Matricula = txtMatricula.Text;
                if (picImagemRecortada.Image != null)
                {
                    usuario.Imagem = ImageToByteArray(picImagemRecortada.Image);
                }
                string erro = string.Empty;
                if (usuarioIDFace.IncluirUsuario(usuario,ref erro))
                {
                    MessageBox.Show("Usuário cadastrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparTela();
                }else
                {
                    MessageBox.Show(erro, "Inclusão",  MessageBoxButtons.OK,  MessageBoxIcon.Error);
                }
               
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void LimparTela()
        {
            txtId.Clear();
            txtMatricula.Clear();
            txtUser.Clear();
            picCamImagem.Image = null;
            picImagemRecortada.Image = null;

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            IncluirUsuario();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCrudUsuario();
            frm.Show();
        }

        private Device _device;
        private Device device
        {
            get
            {
                if (_device == null)
                {
                    _device = new Device();
                    var IOConfiguracao = new Services.IOConfiguracao();
                    var conectIDFace = new ConectaIDFace();
                    _device = conectIDFace.IniciarConexao(IOConfiguracao.GetIPTerminal());
                    _device = new Device(new Util().GetIpTerminal(), new Util().GetIpServer());
                }

                return _device;
            }
        }

        private void setarOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            device.ChangeType(true);
        }

        private void setarOfflineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            device.ChangeType(false);
        }

        private void liberarAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var usuarioIDFace = new UsuarioIDFace();
                usuarioIDFace.LiberarAcesso();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
