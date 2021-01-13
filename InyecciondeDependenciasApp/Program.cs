using System;
using Interfaces;
using Negocio;
using Entidades;
namespace InyecciondeDependenciasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPersistencia persistencia = null; //aqui yo deberia instarciarse
           


            Secretaria secretaria = new Secretaria(persistencia);
            Estudiante estudiante = new Estudiante("Elsa", "Patito");
            Curso curso = new Curso("Programacion");

            secretaria.Matricular(estudiante, curso);


        }
    }
}
