namespace InyecciondeDependenciasApp
{
    interface IPersistencia
    {
        public bool Grabar(Estudiante estudiante);

        public bool Grabar(Curso curso);

        public bool Grabar(EstudiantePorCurso estudiantePorCurso);
       
    }
}
