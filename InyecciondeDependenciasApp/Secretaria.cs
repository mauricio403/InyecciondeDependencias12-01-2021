namespace InyecciondeDependenciasApp
{
    class Secretaria
    {
        IPersistencia persistencia;
        public Secretaria(IPersistencia persistencia)
        {
            this.persistencia = persistencia; 
        }
        
        
        internal string Matricular(Estudiante estudiante, Curso curso)
        {
            
            persistencia.Grabar(estudiante);
            persistencia.Grabar(curso);
            persistencia.Grabar(new EstudiantePorCurso { EstudianteId = estudiante.Id, CursoId = curso.Id });

            return string.Format("El estudiante  {0} {1} se matriculó en el curso de {2}"
                , estudiante.Nombre
                , estudiante.Apellido
                , curso.Nombre);
        }
    }
}
