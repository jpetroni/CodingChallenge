using CodingChallenge.Data.Geometria.Base;
using CodingChallenge.Data.Glogalozacion.Recursos;
using System;

namespace CodingChallenge.Data.Geometria.Forma
{
    public class Circulo : FormaBase
    {
        public Circulo(decimal radio) 
        {
            Radio = radio;
        }

        public override decimal Area
        {
            get
            {
                return Pi * (Radio/ 2) * (Radio / 2);
            }
        }

        public override string Nombre
        {
            get
            {
                return StringResources.CirculoStr;
            }
        }

        public override decimal Perimetro
        {
            get
            {
                return Pi * Radio;
            }
        }
    }
}
