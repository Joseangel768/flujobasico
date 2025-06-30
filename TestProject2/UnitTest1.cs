using ConsoleApp12.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ConsoleApp12.models.MaquinaCafe;

namespace TestProject2
{
    [TestClass]
    public class Maquinacafetest
    {
        [TestMethod]
        public void PequeñoCon1Azucar_DeberiaServirCafeCorrectamente()
        {
            var cafetera = new Cafetera(0);
            var azucarero = new Azucarero(5);
            var vasos = new Vasos(3);
            var maquina = new MaquinaCafe(cafetera, azucarero, vasos);

            var resultado = maquina.ServirCafe(TamañoVaso.Pequeño, 1);

            Assert.AreEqual("Café servido: tamaño pequeño con 1 cucharada(s) de azúcar", resultado);
        }

        [TestMethod]
        public void SinCafe_DeberiaMostrarMensajeDeError()
        {
            var cafetera = new Cafetera(0); // no hay café
            var azucarero = new Azucarero(5);
            var vasos = new Vasos(3);
            var maquina = new MaquinaCafe(cafetera, azucarero, vasos);

            var resultado = maquina.ServirCafe(TamañoVaso.Pequeño, 1);

            Assert.AreEqual("No hay suficiente café", resultado);
        }

        [TestMethod]
        public void SinVasos_DeberiaMostrarMensajeDeError()
        {
            var cafetera = new Cafetera(10);
            var azucarero = new Azucarero(5);
            var vasos = new Vasos(0); // no hay vasos
            var maquina = new MaquinaCafe(cafetera, azucarero, vasos);

            var resultado = maquina.ServirCafe(TamañoVaso.Mediano, 2);

            Assert.AreEqual("No hay vasos disponibles", resultado);
        }

        [TestMethod]
        public void SinAzucar_DeberiaMostrarMensajeDeError()
        {
            var cafetera = new Cafetera(10);
            var azucarero = new Azucarero(0); // no hay azúcar
            var vasos = new Vasos(3);
            var maquina = new MaquinaCafe(cafetera, azucarero, vasos);

            var resultado = maquina.ServirCafe(TamañoVaso.Grande, 2);

            Assert.AreEqual("No hay suficiente azúcar", resultado);
        }

    }
}
