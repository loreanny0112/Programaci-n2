using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class InstrumentoMusical
    {
        public virtual void Tocar()
        {
            Console.WriteLine("El instrumento está siendo tocado");
        }
    }

    public class Guitarra : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("La guitarra está sonando");
        }
    }

    public class Piano : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("El piano está sonando");
        }
    }
}
