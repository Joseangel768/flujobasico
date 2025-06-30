using ConsoleApp12.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Maquinacafetest
    {
        public void ServirCafe_PequeñoCon1Azucar_DeberiaServirCafeCorrectamente()
        {
            // Arrange
            var cafetera = new Cafetera(10); // 10 Oz de café disponibles
            var azucarero = new Azucarero(5); // 5 cucharadas disponibles
            var vasos = new Vasos(3); // 3 vasos pequeños

            var maquina = new MaquinaCafe(cafetera, azucarero, vasos);

            // Act
            var resultado = maquina.ServirCafe(MaquinaCafe.TamañoVaso.Pequeño, 1);

            // Assert
            Assert.AreEqual("Café servido: tamaño pequeño con 1 cucharada(s) de azúcar", resultado);
        }
    }
}
