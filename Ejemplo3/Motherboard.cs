using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Motherboard : Insumos
    {
        public Motherboard() 
        {
            socket = new Zocalo();
        }

        public Zocalo socket { get; }
    }
}
