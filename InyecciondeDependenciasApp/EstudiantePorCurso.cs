using System;

namespace InyecciondeDependenciasApp
{
    class EstudiantePorCurso
    {
        public int EstudianteId { get; set; }

        public int CursoId { get; set; }

        public int Id { get; set; } = new Random().Next();
    }
}
