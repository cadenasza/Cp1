﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1
{
    public class Retangulo : FormaGeometrica
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
