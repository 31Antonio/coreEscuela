using coreEscuela.Entidades;
using System.Linq;



namespace coreEscuela
{
    public class EscuelaEngine
    {
        public EscuelaEngine(Escuela escuela) 
        {
            this.Escuela = escuela;
   
        }

        public EscuelaEngine()
        {
        }

        public Escuela Escuela { get; set; }


        public void Inicializar()
        {
            Escuela = new Escuela("ESCUELA BASICA CRUZ GRANDE", 2004, TiposEscuela.Primeria, pais: "Republica Dominicana", ciudad: " Santo Domingo ", provincia: "Santo Domingo Norte"
            );

           CargarCurso();
           CargarAsignatura();
           CargarEvaluaciones();


        }

        

        private void CargarEvaluaciones()
        {
            for (int i1 = 0; i1 < Escuela.Cursos.Count; i1++)
           {
                Curso? curso = Escuela.Cursos[i1];
                foreach (var asignatura in curso.Asignaturas)
                {
                        foreach (var alumno in curso.Alumnos)
                        {
                            var rnd = new Random(System.Environment.TickCount);

                            for(int i = 0; i < 10; i ++)
                            {
                            var evaluacion = new Evaluaciones
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} evaluacion#{ i + 1} ",
                                Nota = (float)( 10 * rnd.NextDouble()),
                            };
                            
                            }

                        }
                }
           }
        }
        

        private void CargarAsignatura()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignatura = new List<Asignatura>()
                {

                    new Asignatura{Nombre = "Lenguas Española" },
                    new Asignatura{Nombre = "Matemática" },
                    new Asignatura{Nombre = "Naturales" },
                    new Asignatura{Nombre = "Biología" },
                    new Asignatura{Nombre = "Geografía" },
                    new Asignatura{Nombre = "Ciencias Sociales" },
                    new Asignatura{Nombre = "Quimica Organica" },
                    new Asignatura{Nombre = "Educación Fisíca" },
                    new Asignatura{Nombre = "Educación Cívica" },
                    new Asignatura{Nombre = "Fisíca Basica" },
                    new Asignatura{Nombre = "Informatica" },
                    new Asignatura{Nombre = "English" },
                    new Asignatura{Nombre = "Religión" },
                    
                }
                ;
                    curso.Asignaturas = listaAsignatura;

            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string [] nombre1 = {"Antonio", "Enmanuel", "Alba", "Jairo","Paula", "Milka", "Vanessa", "Maria","Arelis","Rosa"};
            string [] apellido1 = { "Rodriguez", "Sarmiento","Martinez","Campusano", "Paulino","De La Rosa","Frias","Fernandes","Cabrera","Ramos"};
            string [] nombre2 = {"Luisa","Frddy", " Jan Carlos", "Miguel", "Exquiel", "Alberto","Juan","Pedro","Jesus","Aristides"};

             var listaAlunmos = from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                              select new Alumno{ Nombre=$"{n1} {n2} {a1}" };

                       return listaAlunmos.OrderBy((al) => al.uniqueId).Take(cantidad).ToList();
        }
        
        

        private void CargarCurso()
        {
                    Escuela.Cursos = new List<Curso>()
                    {
                                new Curso(){Nombre ="101", Jornada = (int)TiposJornada.Manana},
                                new Curso(){Nombre ="201", Jornada = (int)TiposJornada.Manana},
                                new Curso  {Nombre ="301", Jornada = (int)TiposJornada.Manana},
                                new Curso() { Nombre = "401", Jornada = (int)TiposJornada.Tarde},
                                new Curso() { Nombre = "501", Jornada = (int)TiposJornada.Tarde }
                                
                    };
                    
                       Random rnd = new Random ();
                       

                        foreach (var c in Escuela.Cursos)
                        {
                            int cantRandom = rnd.Next(5, 20);
                            c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
                        }
                     
            }
        }
    } 



