using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transmilenio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransMilenio bus = new TransMilenio(); //Se crea un nuevo objeto del tipo Transmilenio

            bus.MostrarCapacidad(); // se ejecuta/llama/instancia el metodo Mostrarcapacidad() de la clase Transmilenio

            bus.Acomodar("Juan"); // uso del metodo Acomodar(parametro parajero)
            bus.Acomodar("Laura");
            bus.Acomodar("Pedro");
            bus.Acomodar("Maria");
            bus.Acomodar("Carlos");
            bus.Acomodar("Sofia");
            bus.Acomodar("Andres");
        }
    }

    public class TransMilenio //se declara la clase Transmilenio
    {
        public string[] Numrojo = new string[10]; // se crea una matriz/arreglo del tipo String, y se inicializa con 10 espacios
        public string[] Numroazul = new string[7];
        public string[] Parados = new string[15];

        public void MostrarCapacidad()  // se crea un metodo vacio y sin parametros MostrarCapacidad()
        {
            Console.WriteLine("El número de asientos azules es " + Numroazul.Length);  //El metodo imprime en su bloque de codigo la cantidad de asientos
            Console.WriteLine("El número de asientos rojos es " + Numrojo.Length);
            Console.WriteLine("El número de personas de pie es " + Parados.Length);
            Console.WriteLine();
        }

        public void Acomodar(string pasajero) //se crea un metodo vacio y con un parametro Acomodar(String pasajeros)
        {
            for (int i = 0; i < Numroazul.Length; i++)  // se crea un bucle for (inicializa i en 0; mientras que i sea menor que la cantidad de asientos azules, se repite el bucle; incremento de 1 en i)
            {
                if (Numroazul[i] == null)  // la condicion dice: si lo que esta en el espacio del indice i en la cadena de asientos azules es nulo, se ejecuta el bloque de codigo
                {                           //como no inicializamos el valor en cada espacio del arreglo, se evalua si su valor es nulo, en este contexto comprendiendo esto como los "Asientos libres"
                    Numroazul[i] = pasajero; //se le asigna al asiento el nombre del pasajero
                    Console.WriteLine(pasajero + " se sentó en el asiento " + (i + 1));
                    return;
                }
            }

            for (int i = 0; i < Numrojo.Length; i++)
            {
                if (Numrojo[i] == null)
                {
                    Numrojo[i] = pasajero;
                    Console.WriteLine(pasajero + " se sentó en el asiento " + (Numroazul.Length + i + 1));
                    return;
                }
            }

            for (int i = 0; i < Parados.Length; i++)
            {
                if (Parados[i] == null)
                {
                    Parados[i] = pasajero;
                    Console.WriteLine(pasajero + " está de pie en el espacio " + (i + 1));
                    return;
                }
            }

            Console.WriteLine("El TransMilenio está lleno"); //todos los bucles asignan un asiento si se cumple una condicion, si no se cumple ninguna condicion (Ningun asiento esta disponible) se imprime que el transmi esta lleno
        }
    }
}
