using System;

namespace CodingChallenge.Data.Geometria.Base
{
    public abstract class FormaBase
    {
        public decimal Radio { get; set; }
        public decimal Pi { get; } = (decimal)Math.PI;
        public decimal LadoA { get; set; }
        public decimal LadoB { get; set; }
        public decimal LadoC { get; set; }
        public decimal LadoBase { get; set; }
        public decimal Altura { get; set; }
        public abstract decimal Area { get; }
        public abstract decimal Perimetro { get; }
        public abstract string Nombre { get; }

        public Type tipo()
        {
            return this.GetType();
        }
    }
}
