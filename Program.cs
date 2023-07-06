// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;   
using System.Collections.Generic;   
using coreEscuela.Entidades;
using coreEscuela.Util;
using static System.Console;



namespace coreEscuela
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDO A LA ESCUELA");
            Printer.Beep();
            ImprimirCursosEcuela(engine.Escuela);


        }

    
        private static void ImprimirCursosEcuela(Escuela escuela)
        {
        
            Printer.WriteTitle("Cursos de la Escuela");
          
          
            if (escuela?.Cursos != null)
            {

                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.uniqueId}");
                }
            }
        }

        
    }
}

