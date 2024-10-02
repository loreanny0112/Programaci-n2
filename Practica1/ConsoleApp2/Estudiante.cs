using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Estudiante : Persona
    {
        public string Grado { get; set; }

        public void MostrarInformacionEstudiante()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Grado: {Grado} ");
        }
    }
}
