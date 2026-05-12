namespace Entidades
{
    public class IteracionSecante
    {
        public IteracionSecante(double cofA, double cofB, double cofC, double cofD, double x0, double x1, double error)
        {
            CofA = cofA;
            CofB = cofB;
            CofC = cofC;
            CofD = cofD;
            X0 = x0;
            X1 = x1;
            Error = error;
        }

        public double CofA { get; set; }
        public double CofB { get; set; }
        public double CofC { get; set; }
        public double CofD { get; set; }
        public double X0 { get; set; }
        public double X1 { get; set; }
        public double Error { get; set; }
    }
}
