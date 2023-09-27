using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PruebaBaseDeDatos.Servicios
{
    internal class ImplConectarBaseDatos : InterfazConectarBaseDeDatos
    {

        public NpgsqlConnection ConectarBaseDatos()
        {
            //datos
            String Host = "";
            String User = "";
            String DBname = "";
            String Password = "";
            String Port = "";

            string connString =
                String.Format(
                    "Host={0};Port={1};Database={2};Username={3};Password={4};SSLMode=Prefer",
                    Host,
                    Port,
                    DBname,
                    User,
                    Password);

            
            NpgsqlConnection connection = new NpgsqlConnection(connString);
            return connection;
        }

        public void ImprimirBD(NpgsqlConnection connection)
        {
            connection.Open();
            string sql = "SELECT * FROM gbp_almacen.gbp_alm_cat_libros;";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // Procesa los datos aquí
                Console.WriteLine($"id_libro: {reader["id_libro"]}, titulo: {reader["titulo"]}");
            }

            reader.Close();
            connection.Close();
        }



    }
}