using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.models
{
    public class Cafetera
    {
        public int CantidadCafe { get; private set; }

        public Cafetera(int cantidadInicial)
        {
            CantidadCafe = cantidadInicial;
        }

        public bool UsarCafe(int cantidad)
        {
            if (CantidadCafe >= cantidad)
            {
                CantidadCafe -= cantidad;
                return true;
            }
            return false;
        }
    }

}
