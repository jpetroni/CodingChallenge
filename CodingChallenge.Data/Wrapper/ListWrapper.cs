    using CodingChallenge.Data.Constantes;
using CodingChallenge.Data.Geometria.Base;
using CodingChallenge.Data.Glogalozacion.Recursos;
using CodingChallenge.Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.Data.Wrapper
{
    public class ListFormaWrapper : List<FormaBase>
    { 
        public decimal TotalAreaType(Type t)
        { 
            return this.Where(w => w.GetType() == t).Sum(s => s.Area); 
        }
        public decimal TotalPerimetroType(Type t)
        {  
            return this.Where(w => w.GetType() == t).Sum(s => s.Perimetro); 
        }
        public string NombreType(Type t) {
            return this.Where(w => w.GetType() == t).FirstOrDefault().Nombre;
        }
        public decimal TotalArea()
        {
            return this.Sum(s => s.Area);
        }
        public decimal TotalPerimetro()
        {
            return this.Sum(s => s.Perimetro);
        }
        public int Ocurrencia(Type t)
        {
            return this.Count(w => w.GetType() == t);
        }
        public string ResumenStr(Type t)
        {
            return Ocurrencia(t) == 0 ? "" : $"{Ocurrencia(t)} {Gram.Pluralize(NombreType(t), Ocurrencia(t))} | {StringResources.AreaStr} {TotalAreaType(t):#.##} | {StringResources.PerimetroStr} {TotalPerimetroType(t):#.##} ";
        }
        public string ResumenTotalStr()
        {
            return $"{HtmlTag.Br}TOTAL:{HtmlTag.Br}{this.Count} {StringResources.FormasStr} {StringResources.PerimetroStr} {TotalPerimetro():#.##} {StringResources.AreaStr} {TotalArea():#.##}";
        }
    }
}
