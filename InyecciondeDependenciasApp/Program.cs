using System;

namespace InyecciondeDependenciasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //IPersistencia persistencia = new Persistencia();
            IPersistencia persistencia = new Persistencia2();


            Secretaria secretaria = new Secretaria(persistencia);
            Estudiante estudiante = new Estudiante("Elsa", "Patito");
            Curso curso = new Curso("Programacion");

            secretaria.Matricular(estudiante, curso);


        }
    }
}
