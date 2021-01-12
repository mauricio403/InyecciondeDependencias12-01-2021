using System.Collections.Generic;
using System.IO;

namespace InyecciondeDependenciasApp
{
    class Persistencia2 : IPersistencia
    {
        public bool Grabar(Estudiante estudiante)
        {
            File.AppendAllLines("Estudiante.txt", new List<string> { estudiante.Nombre, estudiante.Apellido });
            return true;
        }
        public bool Grabar(Curso curso)
        {
            File.AppendAllLines("Curso.txt", new List<string> { curso.Nombre });
            return true;
        }
        public bool Grabar(EstudiantePorCurso estudiantePorCurso)
        {
            File.AppendAllLines("EstudiantePorCurso.txt", new List<string> { estudiantePorCurso.CursoId.ToString() });
            return true;
        }
    }
}
