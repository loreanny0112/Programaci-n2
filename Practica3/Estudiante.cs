using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Estudiante
    {
        public string Nombre {  get; set; }
        public double Calificacion { get; set; }

        public Estudiante(string nombre, double calificacion)
        {
            Nombre = nombre;
            Calificacion = calificacion;
        }

    }
    
}
