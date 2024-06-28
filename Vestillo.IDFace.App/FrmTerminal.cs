using DevExpress.XtraExport.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vestillo.IDFace.Entidade;

namespace Vestillo.IDFace.App
{
    public partial class FrmTerminal : Form
    {
        public FrmTerminal()
        {
            InitializeComponent();
        }

        private void IniciarProcesso()
        {
            var IOConfiguracao = new Vestillo.IDFace.Services.IOConfiguracao();

            foreach (var ip in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork && string.IsNullOrEmpty(txtIPOndeTaAPI.Text))
                {
                    txtIPOndeTaAPI.Text = ip.ToString();

                }
            }


            var config = IOConfiguracao.RetornarConfiguracao();
            if (config != null)
            {
                txtTerminal.Text = config.Servidor;
                txtIPOndeTaAPI.Text = string.IsNullOrEmpty(config.ComputadorAPI) ? txtIPOndeTaAPI.Text : config.ComputadorAPI;
            }


        }

        private void FrmTerminal_Load(object sender, EventArgs e)
        {
            IniciarProcesso();
        }


        private void SalvarConfiguracao()
        {
            try
            {
                var configuracao = new Configuracao();
                var IOConfiguracao = new Services.IOConfiguracao();
                configuracao.Servidor = txtTerminal.Text;
                configuracao.ComputadorAPI = txtIPOndeTaAPI.Text;

                IOConfiguracao.SalvarArquivo(configuracao.Servidor,configuracao.ComputadorAPI);
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SalvarConfiguracao();
        }
    }
}
