using CodingChallenge.Data.Geometria.Base;
using CodingChallenge.Data.Glogalozacion.Recursos;
using System;

namespace CodingChallenge.Data.Geometria.Forma
{
    public class Triangulo : FormaBase
    {
        public Triangulo(decimal lado) 
        {
            LadoA = lado;
        }

        public override decimal Area
        {
            get
            {
                return ((decimal)Math.Sqrt(3) / 4) * LadoA * LadoA;
            }
        }

        public override string Nombre
        {
            get
            {
                return StringResources.TrianguloStr;
            }
        }

        public override decimal Perimetro
        {
            get
            {
                return LadoA * 3;
            }
        }
    }
}
