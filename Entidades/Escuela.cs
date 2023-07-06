using coreEscuela.Entidades;
namespace coreEscuela.Entidades
{

    public class Escuela
    {
        public string uniqueId {get; private set;} = Guid.NewGuid().ToString();
        string nombre;
        public string Nombre
        {
            get{ return " Copia: " + nombre; }
            set{ nombre = value.ToUpper(); }
        }

        public int AñoDeCreación{get;set;}

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public string Provincia { get; set; }

        public TiposEscuela  TipoEscuela{ get; set; }

        public  List<Curso> Cursos { get; set;}

        
        
        public  Escuela(string nombre , int año , string pais , string ciudad , string provincia ) => ( Nombre , AñoDeCreación , Pais , Ciudad , Provincia ) = (nombre , año , pais ,ciudad , provincia );

        public  Escuela(string nombre , int año, 
                        TiposEscuela tipo ,
                        string pais =" " , string ciudad=" ", string provincia=" "  )
            {
                (Nombre, AñoDeCreación) = (nombre, año);
                TipoEscuela = tipo;
                Pais =pais;
                Ciudad = ciudad;
                Provincia = provincia;

            }

        public  Escuela()
        {
        }

        public override string ToString()
        {
        return $" Nombre: \" {Nombre} \", Año: {AñoDeCreación}, Tipo: {TipoEscuela} {System.Environment.NewLine}  Pais: {Pais}, Ciudad: {Ciudad}, Provincia: {Provincia}";
        }
                
    }
}