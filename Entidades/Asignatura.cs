using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace coreEscuela.Entidades{

public class Asignatura
{
    public string uniqueId {get; private set;}

    public string Nombre{get; set;}

    
    public Asignatura()=>uniqueId =Guid.NewGuid().ToString();
    

}

}

