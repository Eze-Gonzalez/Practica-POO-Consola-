using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Parlantes : Perifericos, Reproducir
    {
        public string Sonido { get; set; }

        public string Reproduce()
        {
            return "Reproduciendo sonido...";
        }
    }
}
