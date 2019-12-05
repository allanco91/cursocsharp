using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class ConversorDeMoeda
    {
        static double IOF = 0.06;


        static double calculoIOF(double cotDolar, double qntDolar)
        {
            return cotDolar * qntDolar * IOF;
        }
        public static double ValorPagar(double cotDolar, double qntDolar)
        {
            return cotDolar * qntDolar + calculoIOF(cotDolar, qntDolar);
        }
    }
}
