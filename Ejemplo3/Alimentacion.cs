using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Alimentacion : Insumos, Encender
    {
        public int Vatios { get; set; }
        public string Certificacion { get; set; }
        public string Modular { get; set; }

        public string Iniciar()
        {
            return "Encendiendo la PC...";
        }
    }
}
