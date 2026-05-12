using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entidades;

namespace Manejadores
{
    public class ManejadorNewtonRaphson
    {
        // f(x) = Ax³ + Bx² + Cx + D
        public double EvaluarFx(IteracionNewtonRaphson newton, double x)
        {
            return (newton.CofA * Math.Pow(x, 3)) + (newton.CofB * Math.Pow(x, 2)) + (newton.CofC * x) + newton.CofD;
        }

        // f'(x) = 3Ax² + 2Bx + C  ← derivada analítica automática
        private double EvaluarDerivada(IteracionNewtonRaphson newton, double x)
        {
            return (3 * newton.CofA * Math.Pow(x, 2)) + (2 * newton.CofB * x) + newton.CofC;
        }


        /// Metodo de Newton Raphson
        public List<object[]> Calcular(IteracionNewtonRaphson newton, out double raiz)
        {
            var iteraciones = new List<object[]>();
            double xk = newton.X0;
            double xk1 = 0;
            int noIter = 0;
            int maxIter = 1000;  

            do
            {
                double fxk = EvaluarFx(newton, xk);
                double fpxk = EvaluarDerivada(newton, xk);

                if (fpxk == 0)
                    throw new Exception($"La derivada es 0 en x = {xk}. Newton-Raphson no puede continuar.");

                xk1 = xk - (fxk / fpxk);

                double fxk1 = EvaluarFx(newton, xk1);

                iteraciones.Add(new object[] { noIter, xk, xk1, fxk1 });

                noIter++;
                xk = xk1;

                if (Math.Abs(fxk1) <= newton.Error || noIter >= maxIter)
                    break;

            } while (true);

            raiz = xk1;
            return iteraciones;
        }

        public void EstiloTabla(DataGridView tabla)
        {
            // ===== CONFIGURACION GENERAL =====
            tabla.BorderStyle = BorderStyle.None;
            tabla.BackgroundColor = Color.FromArgb(230, 230, 230);
            tabla.EnableHeadersVisualStyles = false;
            tabla.RowHeadersVisible = false;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AllowUserToResizeRows = false;
            tabla.ReadOnly = true;
            tabla.MultiSelect = false;
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tabla.GridColor = Color.LightGray;

            // ===== ENCABEZADOS =====
            tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabla.ColumnHeadersHeight = 45;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 70, 140);
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ===== CELDAS =====
            tabla.DefaultCellStyle.BackColor = Color.White;
            tabla.DefaultCellStyle.ForeColor = Color.Black;
            tabla.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            tabla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            tabla.DefaultCellStyle.SelectionForeColor = Color.Black;

            // ===== FILAS ALTERNADAS =====
            tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // ===== ALTURA FILAS =====
            tabla.RowTemplate.Height = 35;
        }

        // Método separado para configurar columnas
        public void ConfigurarTabla(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.Columns.Add("colN", "No. Iteración");
            tabla.Columns.Add("colXk", "Xk");
            tabla.Columns.Add("colXk1", "Xk+1");
            tabla.Columns.Add("colFXk1", "f(Xk+1)");
            tabla.AllowUserToAddRows = false;
            tabla.ReadOnly = true;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Validar campos vacíos y numéricos
        public bool ValidarCampos(TextBox txtCofA, TextBox txtCofB, TextBox txtCofC, TextBox txtCofD,
                                   TextBox txtX0, TextBox txtError)
        {
           
            if (string.IsNullOrEmpty(txtCofA.Text) || string.IsNullOrEmpty(txtCofB.Text) || string.IsNullOrEmpty(txtCofC.Text) || string.IsNullOrEmpty(txtCofD.Text))
            {
                MessageBox.Show("Revise los campos de la función, se requieren todos.\nSi no tiene el coeficiente, coloque '0'.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            if (!double.TryParse(txtCofA.Text, out double _) || !double.TryParse(txtCofB.Text, out double _) || !double.TryParse(txtCofC.Text, out double _) || !double.TryParse(txtCofD.Text, out double _))
            {
                MessageBox.Show("Introduzca valores numéricos válidos en los coeficientes.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            if (string.IsNullOrEmpty(txtX0.Text) || string.IsNullOrEmpty(txtError.Text))
            {
                MessageBox.Show("Complete los campos faltantes, se requieren el valor inicial X0 y la tolerancia de error.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            if (!double.TryParse(txtX0.Text, out double _) || !double.TryParse(txtError.Text, out double _))
            {
                MessageBox.Show("Introduzca valores numéricos válidos en X0 y Error.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            double error = double.Parse(txtError.Text);
            if (error <= 0)
            {
                MessageBox.Show("El valor del error debe ser mayor a 0.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar derivada con el objeto ya creado
        public bool ValidarDerivada(IteracionNewtonRaphson newton)
        {
            double fpx0 = EvaluarDerivada(newton, newton.X0);

            if (fpx0 == 0)
            {
                MessageBox.Show("La derivada f'(X0) es igual a 0, Newton-Raphson no puede continuar.\nIntente con otro valor inicial.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}
