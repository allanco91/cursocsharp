using System.Globalization;

namespace Course
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
                return true;
            else
                return false;
        }

        public double FaltaPontos()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                double fpontos = 60.0 - NotaFinal();
                return fpontos;
            }
        }
    }
}
