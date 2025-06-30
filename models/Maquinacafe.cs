using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.models
{
    public class MaquinaCafe
    {
        public enum TamañoVaso
        {
            Pequeño = 3,
            Mediano = 5,
            Grande = 7
        }
        private readonly Cafetera _cafetera;
        private readonly Azucarero _azucarero;
        private readonly Vasos _vasos;

        public MaquinaCafe(Cafetera cafetera, Azucarero azucarero, Vasos vasos)
        {
            _cafetera = cafetera;
            _azucarero = azucarero;
            _vasos = vasos;
        }

        public string ServirCafe(TamañoVaso tamaño, int azucar)
        {
            if (!_vasos.UsarVaso()) return "No hay vasos disponibles";
            if (!_cafetera.UsarCafe((int)tamaño)) return "No hay suficiente café";
            if (!_azucarero.UsarAzucar(azucar)) return "No hay suficiente azúcar";

            return $"Café servido: tamaño {tamaño.ToString().ToLower()} con {azucar} cucharada(s) de azúcar";
        }
    }

}
