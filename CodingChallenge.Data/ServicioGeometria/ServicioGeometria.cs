using CodingChallenge.Data.Constantes;
using CodingChallenge.Data.Excepcion;
using CodingChallenge.Data.Geometria.Forma;
using CodingChallenge.Data.Glogalozacion;
using CodingChallenge.Data.Glogalozacion.Recursos;
using CodingChallenge.Data.Wrapper;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace CodingChallenge.Data
{
    public class ServicioGeometria : IServicioGeometria
    {
        private readonly ListFormaWrapper _formas; 
        public ServicioGeometria(ListFormaWrapper formas, IdiomaCodigo idioma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma.ObtenerDescripcion());
            if (!formas.Any())
                throw new NegocioException($"{HtmlTag.OH1}{StringResources.ListaFormasVacia}{HtmlTag.CH1}");
            _formas = formas;
        }
        
        public string Imprimir() 
        { 
            var sb = new StringBuilder();
            sb.Append($"{HtmlTag.OH1}{StringResources.HeaderStr}{HtmlTag.CH1}");
            var resumen = string.Join(HtmlTag.Br,
                new string[] 
                {
                    _formas.ResumenStr(typeof(Cuadrado)),
                    _formas.ResumenStr(typeof(Circulo)),
                    _formas.ResumenStr(typeof(Triangulo)),
                    _formas.ResumenStr(typeof(Trapecio)),
                    _formas.ResumenStr(typeof(Rectangulo))
                }
                .Where(w => !string.IsNullOrEmpty(w)));
            sb.Append(resumen); 

            sb.Append(_formas.ResumenTotalStr());

            return sb.ToString();
        }
    }
}
