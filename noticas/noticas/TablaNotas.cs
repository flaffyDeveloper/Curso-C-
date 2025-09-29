using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noticas
{
    internal class TablaNotas
    {
        double[,] notas = new double[3, 2];
        public TablaNotas()
        {
            double nota;
           
            for(int i = 0;i < notas.GetLength(0); i++)
            {
                Console.WriteLine("Estudiante {0}",i+1);
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.WriteLine("Nota materia {0}", j + 1);
                    do
                    {
                        nota = Convert.ToDouble(Console.ReadLine());
                        if (nota > 5 || nota < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ingrese un valor entre 0 y 5 para la nota del estudiante");
                            Console.ResetColor();
                        }
                        else
                        {
                            notas[i, j] = nota;
                        }
                    } while (nota > 5 || nota < 0);
                    Console.Clear();
                    
                }
                

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingreso la nota para todos los estudiantes!");
            Console.ResetColor();
            Console.WriteLine("Presione cualquier tecla para continuar...");

            Console.ReadKey();
            Console.Clear();

        }

        public void Mostrar()
        {
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Estudiante {0} ", i+1);
                Console.ResetColor();
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (notas[i, j] < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nota materia {0}: {1}", j + 1,notas[i, j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Nota materia {0}: {1}", j + 1, notas[i, j]);
                        Console.ResetColor();

                    }
                }
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }

        public void espEstudiante()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numero del estudiante que desea consultar:");
            Console.ResetColor();
            int indEstudiante = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Materia del estudiante cuya nota desea consultar:");
            int indMateria = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("La nota del estudiante {0} en la materia {1} es: {2}", indEstudiante, indMateria, notas[indEstudiante-1,indMateria-1]);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
