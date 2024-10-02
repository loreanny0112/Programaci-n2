using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>
                {
                new Guitarra(),
                new Piano()
            };

            foreach(var instrumento in instrumentos)
            {
                instrumento.Tocar();
            }
        }
    }
}
