using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorSecante
    {
        // f(x) = Ax³ + Bx² + Cx + D
        public double EvaluarFx(IteracionSecante secante, double x)
        {
            return (secante.CofA * Math.Pow(x, 3)) + (secante.CofB * Math.Pow(x, 2)) + (secante.CofC * x) + secante.CofD;
        }

        // Metodo de la Secante
        public List<object[]> Calcular(IteracionSecante secante, out double raiz)
        {
            var iteraciones = new List<object[]>();
            double xk = secante.X0;
            double xk1 = secante.X1;
            double xk2 = 0;
            int noIter = 0;
            int maxIter = 1000;

            do
            {
                double fxk = EvaluarFx(secante, xk);
                double fxk1 = EvaluarFx(secante, xk1);

                if (fxk1 - fxk == 0)
                    throw new Exception($"División por cero en iteración {noIter}. Intenta con otros valores iniciales.");

                xk2 = xk1 - fxk1 * (xk1 - xk) / (fxk1 - fxk);

                double fxk2 = EvaluarFx(secante, xk2);

                iteraciones.Add(new object[] { noIter, xk, xk1, fxk, fxk1 });

                noIter++;
                xk = xk1;
                xk1 = xk2;

                if (Math.Abs(fxk2) <= secante.Error || noIter >= maxIter)
                    break;

            } while (true);

            raiz = xk2;
            return iteraciones;
        }

        // ── Configurar columnas ──────────────────────────────────
        public void ConfigurarTabla(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.Columns.Add("colN", "No. Iteración");
            tabla.Columns.Add("colXk", "Xk");
            tabla.Columns.Add("colXk1", "Xk+1");
            tabla.Columns.Add("colFXk", "f(Xk)");
            tabla.Columns.Add("colFXk1", "f(Xk+1)");
            tabla.AllowUserToAddRows = false;
            tabla.ReadOnly = true;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ── Estilo del DataGridView ──────────────────────────────
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


        // Validar campos vacíos y numéricos 
        public bool ValidarCampos(TextBox txtCofA, TextBox txtCofB, TextBox txtCofC, TextBox txtCofD, TextBox txtX0, TextBox txtX1, TextBox txtError)
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

           
            if (string.IsNullOrEmpty(txtX0.Text) || string.IsNullOrEmpty(txtX1.Text) || string.IsNullOrEmpty(txtError.Text))
            {
                MessageBox.Show("Complete los campos faltantes, se requieren X0, X1 y tolerancia de error.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            if (!double.TryParse(txtX0.Text, out double _) || !double.TryParse(txtX1.Text, out double _) || !double.TryParse(txtError.Text, out double _))
            {
                MessageBox.Show("Introduzca valores numéricos válidos en X0, X1 y Error.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            double error = double.Parse(txtError.Text);
            if (error <= 0)
            {
                MessageBox.Show("El valor del error debe ser mayor a 0.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           
            double x0 = double.Parse(txtX0.Text);
            double x1 = double.Parse(txtX1.Text);
            if (x0 == x1)
            {
                MessageBox.Show("X0 y X1 no pueden ser iguales, generaría división por cero.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar con el objeto ya creado (necesita evaluar f(x))
        public bool ValidarFuncion(IteracionSecante secante)
        {
            double fx0 = EvaluarFx(secante, secante.X0);
            double fx1 = EvaluarFx(secante, secante.X1);

            if (fx0 == fx1)
            {
                MessageBox.Show("f(X0) y f(X1) no pueden ser iguales, generaría división por cero en la fórmula.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}

