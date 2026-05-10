using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Manejadores
{
    public class ManejadorFalsaPosicion
    {
        public double Evaluar(IteracionFalsaPosicion ec, double x) 
        {
            var rs = (ec.CoeficienteA * Math.Pow(x, 3)) + (ec.CoeficienteB * Math.Pow(x, 2)) + (ec.CoeficienteC * x) + ec.CoeficienteD;
            return rs;
        }

        public void FalsaPosicion(IteracionFalsaPosicion ec, double xa, double xb, double e, DataGridView tabla, TextBox rs)
        {
            tabla.Rows.Clear();
            int iteracion = 1;

            double xr = 0, fxr = 0;

            do
            {
                double fxa = Evaluar(ec, xa);
                double fxb = Evaluar(ec, xb);

                xr = xb - ((fxb * (xa - xb)) / (fxa - fxb));
                tabla.Rows.Add(iteracion,xa,xb,xr,fxa,fxr);

                if ((fxa * fxr) < 0) { xb = xr; }
                else { xa = xr; }
                iteracion++;
            }
            while (Math.Abs(fxr) <= e);

            rs.Text = xr.ToString("F4");
        }
    }
}
