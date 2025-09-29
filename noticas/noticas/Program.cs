using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TablaNotas multi = new TablaNotas();
            Console.WriteLine("Mostrar todas las notas");
            multi.Mostrar();
            Console.WriteLine("Mostrar notas de un estudiante");
            multi.espEstudiante();
        }
    }
}
