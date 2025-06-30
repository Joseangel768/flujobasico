using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.models
{
    public class Azucarero
    {
        public int CantidadAzucar { get; private set; }

        public Azucarero(int cantidadInicial)
        {
            CantidadAzucar = cantidadInicial;
        }

        public bool UsarAzucar(int cantidad)
        {
            if (CantidadAzucar >= cantidad)
            {
                CantidadAzucar -= cantidad;
                return true;
            }
            return false;
        }
    }

}
