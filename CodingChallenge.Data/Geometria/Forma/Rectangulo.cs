using System;
using CodingChallenge.Data.Geometria.Base;
using CodingChallenge.Data.Glogalozacion.Recursos;

namespace CodingChallenge.Data.Geometria.Forma
{
    public class Rectangulo : FormaBase
    {
        public Rectangulo(decimal ladoBase, decimal altura)
        {
            LadoBase = ladoBase;
            Altura = altura;
        }
        public override decimal Area
        {
            get
            {
                return LadoBase * Altura;
            }
        }

        public override string Nombre
        {
            get
            {
                return StringResources.RectanguloStr;
            }
        }

        public override decimal Perimetro
        {
            get
            {
                return (LadoBase * 2) + (Altura * 2);
            }
        }
    }
}
