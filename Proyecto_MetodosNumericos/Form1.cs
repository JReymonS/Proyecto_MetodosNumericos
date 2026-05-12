using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MetodosNumericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
