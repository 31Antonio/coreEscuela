using System;
using System.Collections.Generic;
using coreEscuela.Entidades;
using System.Linq;
using System.Threading.Tasks;

namespace coreEscuela{

public class Curso
{
        public Curso(string uniqueId, string nombre, int jornada) 
        {
            this.uniqueId = uniqueId;
    this.Nombre = nombre;
    this.Jornada = jornada;
   
        }
            public string uniqueId {get; private set;}

    public string Nombre{get; set;}

    public int Jornada {get; set;}

    public List<Asignatura> Asignaturas {get; set;}

    public List<Alumno> Alumnos {get; set;}
    public List<Evaluaciones>Evaluaciones { get;  set; }

        
     public Curso()=>uniqueId =Guid.NewGuid().ToString();

}

}