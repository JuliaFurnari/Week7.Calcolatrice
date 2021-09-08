using System;
using Week7.Calcolatrice;

namespace Week7.Calcolatrice.Core
{
    public class CalcolatriceClass
    {

        public double RisolviSomma(double a, double b)
        {
            return a + b;
        }
        public double RisolviSottrazione(double a, double b)
        {
            return a - b;
        }
        public double RisolviMoltiplicazione(double a, double b)
        {
            return a * b;
        }
        public double? RisolviDivisione(double a, double b)
        {
            if (b != 0) return a / b;
            return null;
        }

        public bool VerificaSeAMaggioreDiB(double v1, double v2)
        {
            return (v1 >= v2) ? true : false;
        }

    }   
}
