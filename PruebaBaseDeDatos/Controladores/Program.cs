using PruebaBaseDeDatos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBaseDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfazConectarBaseDeDatos bd = new ImplConectarBaseDatos();

            bd.ImprimirBD(bd.ConectarBaseDatos());


        }
    }
}
