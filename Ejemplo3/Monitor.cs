using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Monitor : Perifericos, MostrarImagen, Encender
    {
        public string TipoPantalla { get; set; }
        public string Forma { get; set; }
        public string Iniciar()
        {
            return "Encendiendo monitor";
        }
        public string Imagen()
        {
            return "Mostrando imagen...";
        }
    }
}
