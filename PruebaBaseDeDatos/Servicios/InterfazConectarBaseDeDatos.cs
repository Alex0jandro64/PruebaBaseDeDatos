using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBaseDeDatos.Servicios
{
    internal interface InterfazConectarBaseDeDatos
    {
        NpgsqlConnection ConectarBaseDatos();

        void ImprimirBD(NpgsqlConnection connection);
    }
}
