using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace Proyecto_MetodosNumericos
{
    public partial class FrmNewtonRaphson : Form
    {
        ManejadorNewtonRaphson mnr;
        public FrmNewtonRaphson()
        {
            InitializeComponent();
            mnr = new ManejadorNewtonRaphson();
            mnr.ConfigurarTabla(DtgDatos);
            mnr.EstiloTabla(DtgDatos);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (mnr.ValidarCampos(TxtCofA, TxtCofB, TxtCofC, TxtCofD, TxtValorInicial, TxtError))
                {
                    IteracionNewtonRaphson p = new IteracionNewtonRaphson(double.Parse(TxtCofA.Text), double.Parse(TxtCofB.Text),
                    double.Parse(TxtCofC.Text), double.Parse(TxtCofD.Text), double.Parse(TxtValorInicial.Text),
                    double.Parse(TxtError.Text));

                    if (mnr.ValidarDerivada(p))
                    {
                        double raiz;
                        List<object[]> iteraciones = mnr.Calcular(p, out raiz);
                        TxtRaiz.Text = raiz.ToString("F4");
                        MostrarIteraciones(iteraciones);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Newton-Raphson", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarIteraciones(List<object[]> iteraciones)
        {
           
            DtgDatos.Rows.Clear();

           
            foreach (object[] fila in iteraciones)
            {
                DtgDatos.Rows.Add(fila);
            }

           
            int ultimaFila = DtgDatos.Rows.Count - 1;
            DtgDatos.Rows[ultimaFila].DefaultCellStyle.BackColor = Color.ForestGreen;
            DtgDatos.Rows[ultimaFila].DefaultCellStyle.ForeColor = Color.White;

           
            TxtRaiz.BackColor = Color.White;
            TxtRaiz.ForeColor = Color.ForestGreen;

            mnr.EstiloTabla(DtgDatos);
            DtgDatos.ClearSelection();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
