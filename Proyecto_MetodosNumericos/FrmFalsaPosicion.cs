using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Entidades;
using Manejadores; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_MetodosNumericos
{
    public partial class FrmFalsaPosicion : Form
    {

        ManejadorFalsaPosicion mfp;
        public FrmFalsaPosicion()
        {
            InitializeComponent();
            mfp = new ManejadorFalsaPosicion();
            mfp.ConfigurarTabla(dtgIteraciones);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            IteracionFalsaPosicion f = new IteracionFalsaPosicion();

            f.CoeficienteA = double.Parse(txtCoeficienteA.Text);
            f.CoeficienteB = double.Parse(txtCoeficienteB.Text);
            f.CoeficienteC = double.Parse(txtCoeficienteC.Text);
            f.CoeficienteD = double.Parse(txtCoeficienteD.Text);

            double xa = double.Parse(txtXa.Text);
            double xb = double.Parse(txtXb.Text);
            double error = double.Parse(txtError.Text);

            mfp.FalsaPosicion(f, xa, xb,error,dtgIteraciones,txtRaiz);

        }
    }
}
