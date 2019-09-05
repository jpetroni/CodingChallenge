using System;
using CodingChallenge.Data.Geometria.Base;
using CodingChallenge.Data.Glogalozacion.Recursos;
using CodingChallenge.Data.Excepcion;

namespace CodingChallenge.Data.Geometria.Forma
{
    public class Trapecio : FormaBase
    {
        public Trapecio(decimal ladoBase, decimal altura, decimal ladoB, decimal ladoAC)
        {
            LadoBase = ladoBase;
            Altura = altura;
            LadoB = ladoB;
            LadoA = ladoAC;
            LadoC = ladoAC;
        }

        public override decimal Area
        {
            get
            {
                return ((LadoBase + LadoB) * Altura) / 2m;
            }
        }

        public override string Nombre
        {
            get
            {
                return StringResources.TrapecioStr;
            }
        }

        public override decimal Perimetro
        {
            get
            {
                return LadoBase + LadoA + LadoB + LadoC;
            }
        }
    }
}
