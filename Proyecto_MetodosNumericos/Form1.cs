using System;
using System.Windows.Forms;

namespace Proyecto_MetodosNumericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbSecante_Click(object sender, EventArgs e)
        {
            FrmSecante s = new FrmSecante();
            s.ShowDialog();
        }

        private void tsbNewtonR_Click(object sender, EventArgs e)
        {
            FrmNewtonRaphson nr = new FrmNewtonRaphson();
            nr.ShowDialog();
        }
        
        private void tsbFalsaPosicion_Click(object sender, EventArgs e)
        {
            FrmFalsaPosicion fp = new FrmFalsaPosicion();
            fp.ShowDialog();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
