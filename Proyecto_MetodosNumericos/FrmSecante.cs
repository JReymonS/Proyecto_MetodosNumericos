using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace Proyecto_MetodosNumericos
{
    public partial class FrmSecante : Form
    {
        ManejadorSecante ms;
        public FrmSecante()
        {
            InitializeComponent();
            ms = new ManejadorSecante();
            ms.ConfigurarTabla(DtgDatos);
            ms.EstiloTabla(DtgDatos);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (ms.ValidarCampos(TxtCofA, TxtCofB, TxtCofC, TxtCofD, TxtValorInicial0, TxtValorInicial1, TxtError))
                {
                    IteracionSecante secante = new IteracionSecante(double.Parse(TxtCofA.Text),
                    double.Parse(TxtCofB.Text), double.Parse(TxtCofC.Text),double.Parse(TxtCofD.Text),
                    double.Parse(TxtValorInicial0.Text), double.Parse(TxtValorInicial1.Text),
                    double.Parse(TxtError.Text));

                    if (ms.ValidarFuncion(secante))
                    {
                        double raiz;
                        List<object[]> iteraciones = ms.Calcular(secante, out raiz);
                        TxtRaiz.Text = raiz.ToString("F4");
                        MostrarIteraciones(iteraciones);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Método Secante", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            ms.EstiloTabla(DtgDatos);
            DtgDatos.ClearSelection();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
