using System;

namespace InyecciondeDependenciasApp
{
    class Curso
    {
        public Curso(string nombre)
        {
            Nombre = nombre;
            Id = new Random().Next();
        }

        public string Nombre { get; set; }
        public int Id { get; set; }
    }
}
