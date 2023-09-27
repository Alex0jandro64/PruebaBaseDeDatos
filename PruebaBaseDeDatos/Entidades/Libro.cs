using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBaseDeDatos.Entidades
{
    internal class Libro
    {
        int id_libro, edicion;
        String titulo, autor, isbn;

        

        public Libro(int id_libro, int edicion, string titulo, string autor, string isbn)
        {
            this.id_libro = id_libro;
            this.edicion = edicion;
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
        }

        public Libro()
        {
        }

        public int Id_libro { get => id_libro; set => id_libro = value; }
        public int Edicion { get => edicion; set => edicion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Isbn { get => isbn; set => isbn = value; }
    }
}
