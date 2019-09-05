using CodingChallenge.Data.Geometria.Base;
using CodingChallenge.Data.Glogalozacion.Recursos;

namespace CodingChallenge.Data.Geometria.Forma
{
    public class Cuadrado : FormaBase
    {
        public Cuadrado(decimal lado)
        {
            LadoA = lado;
        }

        public override decimal Area
        {
            get
            {
                return LadoA * LadoA;
            }
        }

        public override string Nombre
        {
            get
            {
                return StringResources.CuadradoStr;
            }
        }

        public override decimal Perimetro
        {
            get
            {
                return LadoA * 4;
            }
        }  
    }
}
