using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace coreEscuela.Entidades{

public class Alumno
{
    public string uniqueId {get; private set;}

    public string Nombre{get; set;}

    
    public Alumno()=>uniqueId = Guid.NewGuid().ToString();
    

}

}

