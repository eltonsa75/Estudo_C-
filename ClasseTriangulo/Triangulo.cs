// Importação de dependencia
using System;

// Namespace da Classe
namespace ClasseTriangulo {
    class Triangulo { // Nome da Classe
        public double A; // Atributos da Classe
        public double B;
        public double C;

        // Method da área do Triangulo
        public double Area(){
            double p = (A + B + C ) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * ( p - C) );
        }
    }
}