using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Manejadores
{
    public class ManejadorFalsaPosicion
    {
        //Configurar DataGridView
        public void ConfigurarTabla(DataGridView tabla) 
        {
            tabla.Columns.Clear();

            tabla.Columns.Add("iteracion","NO. ITERACIÓN");
            tabla.Columns.Add("xa","Xa");
            tabla.Columns.Add("xb","Xb");
            tabla.Columns.Add("xr","Xr");
            tabla.Columns.Add("fxa","F(Xa)");
            tabla.Columns.Add("fxr","F(Xr)");
            tabla.AllowUserToAddRows = false;

            tabla.ReadOnly = true;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        //Validacion de campos
        public bool ValidarCampos(TextBox txtCofA, TextBox txtCofB, TextBox txtCofC, TextBox txtCofD, TextBox txtXa, TextBox txtXb, TextBox txtError) 
        {
            var rs = true;

            //Funcion
            if (string.IsNullOrEmpty(txtCofA.Text) || string.IsNullOrEmpty(txtCofB.Text) || string.IsNullOrEmpty(txtCofC.Text) || string.IsNullOrEmpty(txtCofD.Text)) 
            {
                MessageBox.Show("Revise los campos de la función, se requieren todos. En caso de no tener el coeficiente, porfavor coloque \'0\'.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rs = false;
            }
            else if(!double.TryParse(txtCofA.Text,out double _) || !double.TryParse(txtCofB.Text,out double _) || !double.TryParse(txtCofC.Text,out double _) || !double.TryParse(txtCofD.Text,out double _))
            {
                MessageBox.Show("Introduzca valores numericos validos porfavor.","¡ATENCIÓN!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rs = false;
            }

            //Limites y error
            else if (string.IsNullOrEmpty(txtXa.Text) || string.IsNullOrEmpty(txtXb.Text) || string.IsNullOrEmpty(txtError.Text)) 
            {
                MessageBox.Show("Complete los campos faltantes, se requieren de limites y tolerancia de error.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rs = false;
            }
            else if(!double.TryParse(txtXa.Text,out double _) || !double.TryParse(txtXb.Text,out double _) || !double.TryParse(txtError.Text,out double _)) 
            {
                MessageBox.Show("Introduzca valores numericos validos porfavor.", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rs = false;
            }
            return rs;
        }


        //Metodo de evaluacion de función
        public double Evaluar(IteracionFalsaPosicion ec, double x) 
        {
            var rs = (ec.CoeficienteA * Math.Pow(x, 3)) + (ec.CoeficienteB * Math.Pow(x, 2)) + (ec.CoeficienteC * x) + ec.CoeficienteD;
            return rs;
        }


        //Validar cambio de signo y b>a
        public bool ValidarLimites(IteracionFalsaPosicion ec,double xa, double xb) 
        {
            bool rs = false;

            if (!(xb > xa)) 
            {
                MessageBox.Show($"Los signos no son correctos el limite Xb: {xb} deberá ser mayor que el limite Xa: {xb}.","¡ATENCIÓN!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            double fxa = Evaluar(ec, xa);
            double fxb = Evaluar(ec, xb);

            if ((fxa * fxb) > 0) 
            {
                MessageBox.Show("¡No existe cambio de signo en los limites!","¡ATENCIÓN!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { rs = true; }
            return rs;
        }

        //Metodo de falsa posicion
        public void FalsaPosicion(IteracionFalsaPosicion ec, double xa, double xb, double e, DataGridView tabla, TextBox rs)
        {
            tabla.Rows.Clear();
            int iteracion = 1;
            double xr = 0, fxr = 0;

            if (ValidarLimites(ec,xa, xb))
            {
                do
                {
                    double fxa = Evaluar(ec, xa);
                    double fxb = Evaluar(ec, xb);
                    xr = xb - ((fxb * (xa - xb)) / (fxa - fxb));
                    fxr = Evaluar(ec, xr);

                    tabla.Rows.Add(iteracion, xa, xb, xr, fxa, fxr);

                    if ((fxa * fxr) < 0) { xb = xr; }
                    else { xa = xr; }
                    iteracion++;
                }
                while (Math.Abs(fxr) > e && iteracion<=200);

                rs.BackColor = Color.White;
                rs.ForeColor = Color.ForestGreen;
                rs.Text = xr.ToString("F4");
            }
        }
    }
}
