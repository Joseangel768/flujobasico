using ConsoleApp12.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ConsoleApp12.models.MaquinaCafe;

namespace TestProject2
{
    [TestClass]
    public class Maquinacafetest
    {
        [TestMethod]
        public void Peque�oCon1Azucar_DeberiaServirCafeCorrectamente()
        {
            var cafetera = new Cafetera(0);
            var azucarero = new Azucarero(5);
            var vasos = new Vasos(3);
            var maquina = new MaquinaCafe(cafetera, azucarero, vasos);

            var resultado = maquina.ServirCafe(Tama�oVaso.Peque�o, 1);

            Assert.AreEqual("Caf� servido: tama�o peque�o con 1 cucharada(s) de az�car", resultado);
        }

        [TestMethod]
        public void SinCafe_DeberiaMostrarMensajeDeError()
        {
            var cafetera = new Cafetera(0); // no hay caf�
            var azucarero = new Azucarero(5);
            var vasos = new Vasos(3);
            var maquina = new MaquinaCafe(cafetera, azucarero, vasos);

            var resultado = maquina.ServirCafe(Tama�oVaso.Peque�o, 1);

            Assert.AreEqual("No hay suficiente caf�", resultado);
        }

        [TestMethod]
        public void SinVasos_DeberiaMostrarMensajeDeError()
        {
            var cafetera = new Cafetera(10);
            var azucarero = new Azucarero(5);
            var vasos = new Vasos(0); // no hay vasos
            var maquina = new MaquinaCafe(cafetera, azucarero, vasos);

            var resultado = maquina.ServirCafe(Tama�oVaso.Mediano, 2);

            Assert.AreEqual("No hay vasos disponibles", resultado);
        }

        [TestMethod]
        public void SinAzucar_DeberiaMostrarMensajeDeError()
        {
            var cafetera = new Cafetera(10);
            var azucarero = new Azucarero(0); // no hay az�car
            var vasos = new Vasos(3);
            var maquina = new MaquinaCafe(cafetera, azucarero, vasos);

            var resultado = maquina.ServirCafe(Tama�oVaso.Grande, 2);

            Assert.AreEqual("No hay suficiente az�car", resultado);
        }

    }
}
