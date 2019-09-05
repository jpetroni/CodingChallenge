using NUnit.Framework;
using CodingChallenge.Data.Geometria.Forma;
using CodingChallenge.Data.Excepcion;
using CodingChallenge.Data.Glogalozacion;
using CodingChallenge.Data.Wrapper;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            try
            {
                var _servicio = new ServicioGeometria(new ListFormaWrapper(), IdiomaCodigo.ES_AR);
            }
            catch (NegocioException e)
            {
                Assert.AreEqual("<h1>Lista vacía de formas!</h1>", e.Message);
            }
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            try
            {
                var _servicio = new ServicioGeometria(new ListFormaWrapper(), IdiomaCodigo.EN_US);
            }
            catch (NegocioException e)
            {
                Assert.AreEqual("<h1>Empty list of shapes!</h1>", e.Message);
            }
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new ListFormaWrapper { new Cuadrado(5) };

            var _servicio = new ServicioGeometria(cuadrados, IdiomaCodigo.ES_AR);

            var resumen = _servicio.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new ListFormaWrapper { new Cuadrado(5),
            new Cuadrado(1),
            new Cuadrado(3)};

            var _servicio = new ServicioGeometria(cuadrados, IdiomaCodigo.EN_US);

            var resumen = _servicio.Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var cuadrados = new ListFormaWrapper {
                new Cuadrado(5),
            new Circulo(3),
            new Triangulo(4),
            new Cuadrado(2),
            new Triangulo(9),
            new Circulo(2.75m),
            new Triangulo(4.2m)};

            var _servicio = new ServicioGeometria(cuadrados, IdiomaCodigo.EN_US);

            var resumen = _servicio.Imprimir();

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var cuadrados = new ListFormaWrapper {
                new Cuadrado(5),
            new Circulo(3),
            new Triangulo(4),
            new Cuadrado(2),
            new Triangulo(9),
            new Circulo(2.75m),
            new Triangulo(4.2m)};

            var _servicio = new ServicioGeometria(cuadrados, IdiomaCodigo.ES_AR);

            var resumen = _servicio.Imprimir();

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConTrapecioEnCastellano()
        {
            var trapecio = new ListFormaWrapper()
            {
                new Trapecio(10,7,6,8)
            };

            var _servicio = new ServicioGeometria(trapecio, IdiomaCodigo.ES_AR);

            var resumen = _servicio.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 56 | Perimetro 32 <br/>TOTAL:<br/>1 formas Perimetro 32 Area 56", resumen);
        }

        [TestCase]
        public void TestResumenListaConRectangulosEnIngles()
        {
            var trapecio = new ListFormaWrapper()
            {
                new Rectangulo(10,30)
            };

            var _servicio = new ServicioGeometria(trapecio, IdiomaCodigo.EN_US);

            var resumen = _servicio.Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>1 Rectangle | Area 300 | Perimeter 80 <br/>TOTAL:<br/>1 shapes Perimeter 80 Area 300", resumen);
        }

        [TestCase]
        public void TestResumenListaConTodosEnIngles()
        {
            var trapecio = new ListFormaWrapper()
            {
                new Rectangulo(10,30),
                new Trapecio(10,7,6,8),
                 new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
            };

            var _servicio = new ServicioGeometria(trapecio, IdiomaCodigo.EN_US);

            var resumen = _servicio.Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 4 | Perimeter 8 <br/>1 Circle | Area 7,07 | Perimeter 9,42 <br/>1 Triangle | Area 6,93 | Perimeter 12 <br/>1 Trapeze | Area 56 | Perimeter 32 <br/>1 Rectangle | Area 300 | Perimeter 80 <br/>TOTAL:<br/>5 shapes Perimeter 141,42 Area 374", resumen);
        }

        [TestCase]
        public void TestResumenListaConTodosCastellano()
        {
            var trapecio = new ListFormaWrapper()
            {
                new Rectangulo(10,30),
                new Trapecio(10,7,6,8),
                 new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
            };

            var _servicio = new ServicioGeometria(trapecio, IdiomaCodigo.ES_AR);

            var resumen = _servicio.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 4 | Perimetro 8 <br/>1 Círculo | Area 7,07 | Perimetro 9,42 <br/>1 Triángulo | Area 6,93 | Perimetro 12 <br/>1 Trapecio | Area 56 | Perimetro 32 <br/>1 Rectangulo | Area 300 | Perimetro 80 <br/>TOTAL:<br/>5 formas Perimetro 141,42 Area 374", resumen);
        }

        [TestCase]
        public void TestResumenListaConTodosFrances()
        {
            var trapecio = new ListFormaWrapper()
            {
                new Rectangulo(10,30),
                new Trapecio(10,7,6,8),
                 new Circulo(3),
                new Triangulo(4),
                new Cuadrado(2),
            };

            var _servicio = new ServicioGeometria(trapecio, IdiomaCodigo.FR_FR);

            var resumen = _servicio.Imprimir();

            Assert.AreEqual("<h1>Rapport de formulaires</h1>1 Carré | Zone 4 | Périmètre 8 <br/>1 Cercle | Zone 7,07 | Périmètre 9,42 <br/>1 Triangle | Zone 6,93 | Périmètre 12 <br/>1 Trapèze | Zone 56 | Périmètre 32 <br/>1 Rectangle | Zone 300 | Périmètre 80 <br/>TOTAL:<br/>5 formes Périmètre 141,42 Zone 374", resumen);
        }
    }
}
