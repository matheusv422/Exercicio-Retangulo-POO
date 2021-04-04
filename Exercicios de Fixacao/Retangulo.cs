using System;
using System.Globalization;
namespace Exercicios_de_Fixacao
{
    class Retangulo
    {
        public double Largura, Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0));
        }

        public override string ToString()
        {

            return "AREA = " + Area()
                .ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                "PERIMETRO = " + Perimetro()
                .ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                "DIAGONAL = " + Diagonal()
                .ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}