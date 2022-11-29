using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class PC
    {
        public Gabinete gab = new Gabinete();
        public Motherboard placaBase = new Motherboard();
        public Teclado keyboard = new Teclado();
        public Ram ram = new Ram();
        public Parlantes parlante = new Parlantes();
        public Mouse raton = new Mouse();
        public Monitor pantalla = new Monitor();
        public GPU grafica = new GPU();
        public CPU procesador = new CPU();
        public Almacenamiento hdd = new Almacenamiento();
        public Alimentacion fuente = new Alimentacion();
        public Parlantes altavoz = new Parlantes();

        public string Conectar()
        {
            return "Todos los componentes estan conectados, PC lista para inciar";
        }
        public string Conectar(string opcion)
        {
            return "Todos los componentes internos estan conectados, pero, no hay perifericos";
        }
    }
}
