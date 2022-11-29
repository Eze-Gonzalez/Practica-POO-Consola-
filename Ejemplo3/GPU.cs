using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class GPU : Insumos
    {
        public int Fan { get; set; }
        public int VRam { get; set; }
        public int Frecuencia { get; set; }
    }
}
