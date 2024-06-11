using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            var config = IOConfiguracao.RetornarConfiguracao();
            if (config != null)
            {
                txtTerminal.Text = config.Servidor;
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
                var configuracao = new Entidade.Configuracao();
                var IOConfiguracao = new Services.IOConfiguracao();
                configuracao.Servidor = txtTerminal.Text;

                IOConfiguracao.SalvarArquivo(configuracao.Servidor);
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
