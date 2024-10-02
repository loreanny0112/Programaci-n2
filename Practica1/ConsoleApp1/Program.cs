using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {


            Libro libro1 = new Libro();
            libro1.Titulo = "Odisea";
            libro1.Autor = "Homero";
            libro1.Paginas = 312;
            libro1.MostrarInformacion();

        }
    }
}
