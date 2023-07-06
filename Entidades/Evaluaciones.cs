using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace coreEscuela.Entidades{

public class Evaluaciones
{
        public Evaluaciones(string uniqueId, string nombre, Asignatura asignatura) 
        {
            this.uniqueId = uniqueId;
            this.Nombre = nombre;
            this.Asignatura = asignatura;

        }
            public string uniqueId {get; private set;}

    public string Nombre{get; set;}

    public Alumno  Alumno { get; set; }

    public Asignatura Asignatura { get; set; }

    public float  Nota { get; set; }

    
    public Evaluaciones()=>uniqueId =Guid.NewGuid().ToString();
    

}

}

