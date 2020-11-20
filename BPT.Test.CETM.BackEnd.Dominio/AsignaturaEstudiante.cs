using System;
using System.Collections.Generic;
using System.Text;

namespace BPT.Test.CETM.BackEnd.Dominio
{
    public class AsignaturaEstudiante
    {
        public int IdAsignatura { get; set; }

        public int IdEstudiante { get; set; }

        public Asignacion Asignacion { get; set; }

        public Estudiante Estudiante { get; set; }
    }
}
