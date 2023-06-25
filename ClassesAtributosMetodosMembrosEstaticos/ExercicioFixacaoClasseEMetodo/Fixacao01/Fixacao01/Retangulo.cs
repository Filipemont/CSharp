using System;


namespace Fixacao01 {
    internal class Retangulo {
        public double Largura;
        public double Altura;

        public double Area(double altura, double largura) {
        return altura * largura;
        }
        public double Perimetro(double altura, double largura) {
            return (2* altura) + (2* largura);
        }
        public double Diagonal(double altura, double largura) { 
            return Math.Sqrt(Math.Pow(altura, 2) +  Math.Pow(largura, 2));
        }
    }

}
