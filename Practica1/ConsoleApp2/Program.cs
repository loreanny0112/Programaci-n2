using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Nombre = "Loreanny";
            estudiante1.Edad = 20;
            estudiante1.Grado = "Desarrollo de Software";
            estudiante1.MostrarInformacionEstudiante();
        }
    }
}
