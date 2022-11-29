using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PC computadora = new PC();
            Gabinete gab = new Gabinete();
            string opcion;

            Console.WriteLine("Ingrese las opciones de su computadora");

            Console.WriteLine("__________________________");
            Console.WriteLine("Ingrese los datos del gabinete:");
            Console.WriteLine("Fabricante");
            computadora.gab.Fabricante = Console.ReadLine();
            Console.WriteLine("Modelo");
            computadora.gab.Modelo = Console.ReadLine();
            Console.WriteLine("Tamaño");
            computadora.gab.Tamaño = Console.ReadLine();
            Console.WriteLine("__________________________");

            Console.WriteLine("Ingrese el zocalo deseado");
            computadora.placaBase.socket.Tipo = Console.ReadLine();
            computadora.placaBase.socket.Tipo = computadora.placaBase.socket.Tipo.ToLower();
            if (computadora.placaBase.socket.Tipo == "am4" || computadora.placaBase.socket.Tipo == "am5")
                computadora.procesador.Fabricante = "AMD";
            else
                computadora.procesador.Fabricante = "Intel";
            Console.WriteLine("__________________________");

            Console.WriteLine("Ingrese los datos de la placa madre");
            Console.WriteLine("Fabricante");
            computadora.placaBase.Fabricante = Console.ReadLine();
            Console.WriteLine("Modelo");
            computadora.placaBase.Modelo = Console.ReadLine();
            Console.WriteLine("__________________________");

            Console.WriteLine("Ingrese los datos del CPU " + computadora.procesador.Fabricante);
            Console.WriteLine("Modelo");
            computadora.procesador.Modelo = Console.ReadLine();
            Console.WriteLine("Velocidad/Frecuencia");
            computadora.procesador.Velocidad = Console.ReadLine();
            Console.WriteLine("__________________________");

            Console.WriteLine("Ingrese los datos de la memoria RAM");
            Console.WriteLine("Fabricante");
            computadora.ram.Fabricante = Console.ReadLine();
            Console.WriteLine("Modelo");
            computadora.ram.Modelo = Console.ReadLine();
            Console.WriteLine("Tipo");
            computadora.ram.Tipo = Console.ReadLine();
            Console.WriteLine("Capacidad");
            computadora.ram.Cpacidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Frecuencia");
            computadora.ram.Frecuencia = int.Parse(Console.ReadLine());
            Console.WriteLine("__________________________");

            Console.WriteLine("Ingrese los datos de almacenamiento");
            Console.WriteLine("Fabricante");
            computadora.hdd.Fabricante = Console.ReadLine();
            Console.WriteLine("Modelo");
            computadora.hdd.Modelo = Console.ReadLine();
            Console.WriteLine("Tipo");
            computadora.hdd.Tipo = Console.ReadLine();
            Console.WriteLine("Capacidad");
            computadora.hdd.Capacidad = int.Parse(Console.ReadLine());
            Console.WriteLine("__________________________");

            Console.WriteLine("Ingrese los datos de la Placa Grafica");
            Console.WriteLine("Fabricante");
            computadora.grafica.Fabricante = Console.ReadLine();
            Console.WriteLine("Modelo");
            computadora.grafica.Modelo = Console.ReadLine();
            Console.WriteLine("Cantidad de ventiladores");
            computadora.grafica.Fan = int.Parse(Console.ReadLine());
            Console.WriteLine("Capacidad de VRAM");
            computadora.grafica.VRam = int.Parse(Console.ReadLine());
            Console.WriteLine("Frecuencia");
            computadora.grafica.Frecuencia = int.Parse(Console.ReadLine());
            Console.WriteLine("__________________________");

            Console.WriteLine("Ingrese los datos de la fuente de alimentacion");
            Console.WriteLine("Fabricante");
            computadora.fuente.Fabricante = Console.ReadLine();
            Console.WriteLine("Modelo");
            computadora.fuente.Modelo = Console.ReadLine();
            Console.WriteLine("Potencia (Vatios)");
            computadora.fuente.Vatios = int.Parse(Console.ReadLine());
            Console.WriteLine("Certificacion");
            computadora.fuente.Certificacion = Console.ReadLine();
            Console.WriteLine("Es modular? si/no - s/n");
            opcion = Console.ReadLine();
            opcion = opcion.ToLower();
            if (opcion == "s" || opcion == "si")
                computadora.fuente.Modular = "Modular";
            else
                computadora.fuente.Modular = "No modular";
            Console.WriteLine("__________________________");

            Console.WriteLine("Desea agregar perifericos?");
            opcion = Console.ReadLine();
            opcion = opcion.ToLower();

            if(opcion == "si" || opcion == "s")
            {
                Console.WriteLine("Ingrese los datos del teclado");
                Console.WriteLine("Fabricante");
                computadora.keyboard.Fabricante = Console.ReadLine();
                Console.WriteLine("Modelo");
                computadora.keyboard.Modelo = Console.ReadLine();
                Console.WriteLine("Tiene teclado numerico?");
                computadora.keyboard.TecladoNumerico = Console.ReadLine();
                computadora.keyboard.TecladoNumerico = computadora.keyboard.TecladoNumerico.ToLower();
                Console.WriteLine("Tipo de conexion");
                computadora.keyboard.Conexion = Console.ReadLine();
                Console.WriteLine("__________________________");

                Console.WriteLine("Ingrese los datos del mouse");
                Console.WriteLine("Fabricante");
                computadora.raton.Fabricante = Console.ReadLine();
                Console.WriteLine("Modelo");
                computadora.raton.Modelo = Console.ReadLine();
                Console.WriteLine("Ingrese los DPI, si los puede configurar, ingrese dinamico");
                computadora.raton.DPI = Console.ReadLine();
                Console.WriteLine("Tipo de conexion");
                computadora.raton.Conexion = Console.ReadLine();
                Console.WriteLine("__________________________");

                Console.WriteLine("Ingrese los datos de los parlantes");
                Console.WriteLine("Fabricante");
                computadora.altavoz.Fabricante = Console.ReadLine();
                Console.WriteLine("Modelo");
                computadora.altavoz.Modelo = Console.ReadLine();
                Console.WriteLine("Ingrese el tipo de sonido");
                computadora.altavoz.Sonido = Console.ReadLine();
                Console.WriteLine("__________________________");

                Console.WriteLine("Ingrese los datos del monitor");
                Console.WriteLine("Fabricante");
                computadora.pantalla.Fabricante = Console.ReadLine();
                Console.WriteLine("Modelo");
                computadora.pantalla.Modelo = Console.ReadLine();
                Console.WriteLine("Ingrese el tipo de pantalla");
                computadora.pantalla.TipoPantalla = Console.ReadLine();
                Console.WriteLine("Ingrese la forma del Monitor");
                computadora.pantalla.Forma = Console.ReadLine();
                Console.WriteLine("__________________________");
                Console.WriteLine(computadora.Conectar());
            }else
                Console.WriteLine(computadora.Conectar(opcion));


            Console.WriteLine("Los datos de su PC son los siguientes: ");
            Console.WriteLine("Gabinete: ");
            Console.WriteLine("Fabricante: " + computadora.gab.Fabricante);
            Console.WriteLine("Modelo: " + computadora.gab.Modelo);
            Console.WriteLine("Tamaño: " + computadora.gab.Tamaño);
            Console.WriteLine("__________________________");
            Console.WriteLine("Placa Base: ");
            Console.WriteLine("Zocalo: " + computadora.placaBase.socket.Tipo);
            Console.WriteLine("Fabricante: " + computadora.placaBase.Fabricante);
            Console.WriteLine("Modelo: " + computadora.placaBase.Modelo);
            Console.WriteLine("__________________________");
            Console.WriteLine("CPU: ");
            Console.WriteLine("Fabricante: " + computadora.procesador.Fabricante);
            Console.WriteLine("Modelo: " + computadora.procesador.Modelo);
            Console.WriteLine("Frecuencia: " + computadora.procesador.Velocidad);
            Console.WriteLine("__________________________");
            Console.WriteLine("Memoria RAM: ");
            Console.WriteLine("Fabricante: " + computadora.ram.Fabricante);
            Console.WriteLine("Modelo: " + computadora.ram.Modelo);
            Console.WriteLine("Tipo: " + computadora.ram.Tipo);
            Console.WriteLine("Capacidad: " + computadora.ram.Cpacidad);
            Console.WriteLine("Frecuencia: " + computadora.ram.Frecuencia);
            Console.WriteLine("__________________________");
            Console.WriteLine("Almacenamiento: ");
            Console.WriteLine("Fabricante: " + computadora.hdd.Fabricante);
            Console.WriteLine("Modelo: " + computadora.hdd.Modelo);
            Console.WriteLine("Tipo: " + computadora.hdd.Tipo);
            Console.WriteLine("Capacidad: " + computadora.hdd.Capacidad);
            Console.WriteLine("__________________________");
            Console.WriteLine("Placa Grafica: ");
            Console.WriteLine("Fabricante: " + computadora.grafica.Fabricante);
            Console.WriteLine("Modelo: " + computadora.grafica.Modelo);
            Console.WriteLine("Cantidad de ventiladores: " + computadora.grafica.Fan);
            Console.WriteLine("Capacidad de VRAM: " + computadora.grafica.VRam);
            Console.WriteLine("Frecuencia: " + computadora.grafica.Frecuencia);
            Console.WriteLine("__________________________");
            Console.WriteLine("Fuente de alimentacion: ");
            Console.WriteLine("Fabricante: " + computadora.fuente.Fabricante);
            Console.WriteLine("Modelo: " + computadora.fuente.Modelo);
            Console.WriteLine("Potencia (Vatios): " + computadora.fuente.Vatios);
            Console.WriteLine("Certificacion: " + computadora.fuente.Certificacion);
            Console.WriteLine("Tipo de fuente: " + computadora.fuente.Modular);
            Console.WriteLine("__________________________");

            if(opcion == "si" || opcion == "s")
            {
                Console.WriteLine("Teclado: ");
                Console.WriteLine("Fabricante: " + computadora.keyboard.Fabricante);
                Console.WriteLine("Modelo: " + computadora.keyboard.Modelo);
                if (computadora.keyboard.TecladoNumerico == "si")
                    Console.WriteLine("Tiene Teclado Numerico");
                else
                    Console.WriteLine("Sin Neclado Numerico");
                Console.WriteLine("Tipo de conexion: " + computadora.keyboard.Conexion);
                Console.WriteLine("__________________________");

                Console.WriteLine("Mouse: ");
                Console.WriteLine("Fabricante: " + computadora.raton.Fabricante);
                Console.WriteLine("Modelo: " + computadora.raton.Modelo);
                Console.WriteLine("DPI: " + computadora.raton.DPI);
                Console.WriteLine("Tipo de conexion: " + computadora.raton.Conexion);
                Console.WriteLine("__________________________");

                Console.WriteLine("Parlantes");
                Console.WriteLine("Fabricante: " + computadora.altavoz.Fabricante);
                Console.WriteLine("Modelo: " + computadora.altavoz.Modelo);
                Console.WriteLine("Tipo de sonido: " + computadora.altavoz.Sonido);
                Console.WriteLine("__________________________");

                Console.WriteLine("Monitor");
                Console.WriteLine("Fabricante: " + computadora.pantalla.Fabricante);
                Console.WriteLine("Modelo: " + computadora.pantalla.Modelo);
                Console.WriteLine("Tipo de pantalla: " + computadora.pantalla.TipoPantalla);
                Console.WriteLine("Forma del Monitor: " + computadora.pantalla.Forma);
                Console.WriteLine("__________________________");
                Console.WriteLine("Desea encender la PC?");
                opcion = Console.ReadLine();
                opcion = opcion.ToLower();
                if(opcion == "si" || opcion == "s")
                {
                    Console.WriteLine(computadora.fuente.Iniciar());
                    Console.WriteLine(computadora.pantalla.Iniciar());
                    Console.WriteLine(computadora.pantalla.Imagen());
                    Console.WriteLine(computadora.altavoz.Reproduce());
                }else
                    Console.WriteLine("Fin del programa");
            }
            else
                Console.WriteLine("Desea encender la PC?");
                opcion = Console.ReadLine();
                opcion = opcion.ToLower();
            if (opcion == "si" || opcion == "s")
            {
                Console.WriteLine(computadora.fuente.Iniciar());
                Console.WriteLine("Sin Imagen ni sonido");
            }else
                Console.WriteLine("Fin del programa");

            Console.ReadKey();
        }
    }
}
