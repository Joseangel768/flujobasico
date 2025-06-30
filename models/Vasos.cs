using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.models
{
    public class Vasos
    {
        public int CantidadVasos { get; private set; }

        public Vasos(int cantidadInicial)
        {
            CantidadVasos = cantidadInicial;
        }

        public bool UsarVaso()
        {
            if (CantidadVasos > 0)
            {
                CantidadVasos--;
                return true;
            }
            return false;
        }
    }

}
