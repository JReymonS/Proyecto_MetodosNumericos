using System;
using Entidades;
using Manejadores;
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
            mfp.EstiloTabla(dtgIteraciones);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            IteracionFalsaPosicion f = new IteracionFalsaPosicion();

            if (mfp.ValidarCampos(txtCoeficienteA, txtCoeficienteB, txtCoeficienteC, txtCoeficienteD, txtXa, txtXb, txtError))
            {
                f.CoeficienteA = double.Parse(txtCoeficienteA.Text);
                f.CoeficienteB = double.Parse(txtCoeficienteB.Text);
                f.CoeficienteC = double.Parse(txtCoeficienteC.Text);
                f.CoeficienteD = double.Parse(txtCoeficienteD.Text);

                double xa = double.Parse(txtXa.Text);
                double xb = double.Parse(txtXb.Text);
                double error = double.Parse(txtError.Text);

                mfp.FalsaPosicion(f, xa, xb, error, dtgIteraciones, txtRaiz);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
